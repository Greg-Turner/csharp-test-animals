namespace Animals
{

    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Speed { get; set; }
        // Constructor
        public Animal(string name, string species, double speed)
        {
            Name = name;
            Species = species;
            Speed = speed;
        }
        // Run Method
        public virtual double Run()
        {
            return this.Speed;
        }
    }
}