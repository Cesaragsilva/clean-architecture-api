using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Application.Mappings
{
    public static class InputModelToEntity
    {
        public static Car ToEntity(this CarInputModel carInputModel)
            => new (carInputModel.Name, carInputModel.Model);
    }
}
