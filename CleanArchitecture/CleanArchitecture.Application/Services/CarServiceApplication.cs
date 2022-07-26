using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Mappings;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;

namespace CleanArchitecture.Application.Services
{
    public class CarServiceApplication : ICarServiceApplication
    {
        private readonly IBaseRepository<Car> _carRepository;
        public CarServiceApplication(IBaseRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<CarViewModel> CreateAsync(CarInputModel carInputModel)
        {
            var car = carInputModel.ToEntity();
            car = await _carRepository.AddAsync(car);
            return car.ToViewModel();
        }

        public async Task<CarViewModel> DeleteAsync(int id)
        {
            var data = await _carRepository.GetByIdAsync(id);
            if (data is not null)
            {
                await _carRepository.DeleteAsync(data);
                return data.ToViewModel();
            }
            return null;
        }

        public async Task<List<CarViewModel>> GetAllAsync()
        {
            var data = await _carRepository.GetAllAsync();
            if (data is not null)
                return data.ToViewModel();

            return null;
        }

        public async Task<CarViewModel> GetByIdAsync(int id)
        {
            var data = await _carRepository.GetByIdAsync(id);
            if(data is not null)
                return data.ToViewModel();

            return null;
        }
    }
}
