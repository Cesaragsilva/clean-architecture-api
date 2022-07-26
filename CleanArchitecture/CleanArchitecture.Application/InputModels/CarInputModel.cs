using CleanArchitecture.Application.InputModels.Validations;

namespace CleanArchitecture.Application.InputModels
{
    public class CarInputModel
    {
        public CarInputModel(int id, string name, string model)
        {
            Id = id;
            Name = name;
            Model = model;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public bool Valid => new CarInputModelValidator().Validate(this).IsValid;
        public IReadOnlyList<string> Notifications => new CarInputModelValidator().Validate(this).Errors.Select(p => p.ErrorMessage).ToList();
    }
}
