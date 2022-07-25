using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICarServiceApplication
    {
        Task<CarViewModel> CreateAsync(CarInputModel carInputModel);
        Task<List<CarViewModel>> GetAllAsync();
        Task<CarViewModel> GetByIdAsync(int id);
    }
}
