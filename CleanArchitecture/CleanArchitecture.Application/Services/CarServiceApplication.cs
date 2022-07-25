using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.Interfaces;
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

        public Task<CarViewModel> CreateAsync(CarInputModel carInputModel)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CarViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
