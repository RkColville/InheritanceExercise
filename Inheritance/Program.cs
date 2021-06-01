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
            Bird fogHorn = new Bird()
            {
                Name = "fogHorn",
                Eyes = 2,
                Nose = 1,
                Legs = 2,
                Wings = 2,
                Beak = 1,
                LaysEggs = false,
                Feathers = true,

            };

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile killerCroc = new Reptile()
            {
                Name = "Killer Croc",
                Eyes = 2,
                Nose = 1,
                Legs = 2,
                ColdBlooded = true,
                lungs = 2,
                Scales = true,
                LayEggs = false,

            };

        }
    }
}
