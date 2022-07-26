namespace CleanArchitecture.Application.ViewModels
{
    public class CarViewModel
    {
        public CarViewModel(int id, string name, string model, bool isActive, DateTime createAt)
        {
            Id = id;
            Name = name;
            Model = model;
            IsActive = isActive;
            CreateAt = createAt;
        }

        public int Id { get; set; } 
        public string Name { get; set; }
        public string Model { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
