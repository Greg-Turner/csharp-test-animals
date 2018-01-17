namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string species, double speed) : base(name, species, speed)
        {
            Name = name;
            Species = Species;
            Speed = speed;
        }

        // Run Method
        public override double Run()
        {
            return this.Speed;
        }
    }
}