namespace CleanArchitecture.Core.Entities
{
    public class Car : BaseEntity
    {
        public Car(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public string Name { get; set; }
        public string Model { get; set; }
    }
}
