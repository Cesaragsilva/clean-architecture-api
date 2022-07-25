namespace CleanArchitecture.Application.ViewModels
{
    public class CarViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Model { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
