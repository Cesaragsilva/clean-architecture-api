using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Application.Mappings
{
    public static class EntityToViewModel
    {
        public static CarViewModel ToViewModel(this Car carEntity) =>
            new(carEntity.Id, carEntity.Name, carEntity.Model, carEntity.IsActive, carEntity.CreatedAt);

        public static List<CarViewModel> ToViewModel(this List<Car> carEntities)
        {
            var carEntitiesViewModel = new List<CarViewModel>();
            carEntities?.ForEach(car =>
            {
                carEntitiesViewModel.Add(car.ToViewModel());
            });
            return carEntitiesViewModel;
        }
    }
}
