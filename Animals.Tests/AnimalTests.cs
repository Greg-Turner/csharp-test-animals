using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalsShould
    {
        public Animal roadRunner;
        public Dog coyote;

        public AnimalsShould()
        {
            roadRunner = new Animal();
            coyote = new Dog();
        }

        [Fact]
        public void NameAnimal()
        {
            roadRunner.Name = "Road Runner";
            Assert.Equal("Road Runner", roadRunner.Name);
        }


        [Fact]
        public void HoldSpecies()
        {
            roadRunner.Species = "Geococcyx";
            Assert.Equal("Geococcyx", roadRunner.Species);
        }

        [Fact]
        public void roadRunnerRun()
        {
            roadRunner.Speed = 50.0;
            roadRunner.Run();
            Assert.Equal(50.0, roadRunner.Run());
        }


        [Fact]
        public void DogRun()
        {
            coyote.Speed = 49.9;
            coyote.Run();
            Assert.Equal(49.9, coyote.Run());
        }

        [Fact]
        public void IsInstanceOf()
        {
            // Assert statements to test both
            Assert.Equal(typeof(Animal), roadRunner.GetType());
            Assert.Equal(typeof(Dog), coyote.GetType());
        }
    }
}
