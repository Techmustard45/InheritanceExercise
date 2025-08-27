using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird1 = new Bird() {CanFly = true, HasTalons = true, IsDomesticated = false, IsExtinct = false, Legs = 2, Name = "Mighty Eagle", Species = "Eagle", Wingspan = 8.2};
            Console.WriteLine($"My favorite animal is the {bird1.Species} named {bird1.Name}. He has {bird1.Legs} legs and a wingspan of {bird1.Wingspan} feet.");
            if (bird1.CanFly)
            {
                Console.WriteLine("He can also fly.");
            }

            if (bird1.HasTalons)
            {
                Console.WriteLine("He also has talons.");
            }

            if (bird1.IsDomesticated)
            {
                Console.WriteLine("He\'s not a wild animal.");
            }

            if (bird1.IsExtinct)
            {
                Console.WriteLine("His whole species is dead.");
            }
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptiles reptile1 = new Reptiles()
            {
                HasClaws = false, IsDomesticated = true, IsExtinct = false, IsPoisonous = false, IsVenomous = true,
                Legs = 0, Name = "Shane", Species = "Yellow-bellied sea snake"
            };
            
            Console.WriteLine($"My favorite reptile is the {reptile1.Species} named {reptile1.Name}. he has {reptile1.Legs} legs.");
            if (reptile1.HasClaws)
            {
                Console.WriteLine("He has claws.");
            }

            if (reptile1.IsPoisonous)
            {
                Console.WriteLine("He is poisonous.");
            }

            if (reptile1.IsVenomous)
            {
                Console.WriteLine("He is venomous.");
            }

            if (reptile1.IsDomesticated)
            {
                Console.WriteLine("He is not a wild animal.");
            }

            if (reptile1.IsExtinct)
            {
                Console.WriteLine("His whole species is dead.");
            }
        }
    }
}
