using System;
namespace Animals
{
    abstract class Animal
    {
        // Property
        public abstract string Breed { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }
    class Program
    {
        class Pig : Animal
        {
            public override string Breed { get; set; }
            public string Color { get; set; }

            public Pig()
            {
                Breed = string.Empty;
                Color = string.Empty;

            }
            public Pig(string breed, string color)
            {
                Breed = breed;
                Color = color;
            }
            public override string Describe()
            {
                return "I am a " + Breed + "\nI am the color " + Color;
            }
            static void Main(string[] args)
            {
                Pig porkey = new Pig();
                porkey.Breed = "Berkshire";
                porkey.Color = "Brown";
                Console.WriteLine(porkey.whatAmI());
                Console.WriteLine(porkey.Describe());
            }
        }
    }
}