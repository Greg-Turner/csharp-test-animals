using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal roadRunner = new Animal("Road Runner", "Geococcyx", 50.0);
            Dog coyote = new Dog("Coyote", "Canis Latrans", 49.9);

            Console.WriteLine($"The {coyote.Name} (species {coyote.Species}) runs at a speed of {coyote.Run()}.");
            Console.WriteLine($"The {roadRunner.Name} (species {roadRunner.Species}) runs at a speed of {roadRunner.Run()}.");
        }
    }
}
