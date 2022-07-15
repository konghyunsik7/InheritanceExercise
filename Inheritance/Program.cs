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
            var chicken = new bird();

            chicken.CanFly = false;
            chicken.HaveABeak = true;
            chicken.HaveFeathers = true;
            chicken.NumberOfClaws = 8;

            chicken.MaleOrFemale = "male";
            chicken.SetOfLegs = 2;
            chicken.TypeOfAnimal = "bird";
            chicken.HaveATail = false;

            Console.WriteLine($"Can chickens fly? {chicken.CanFly}! Do they have a beak? {chicken.HaveABeak}! Do they have feathers as well? {chicken.HaveFeathers}! How many claws do they have? {chicken.NumberOfClaws}!");
            Console.WriteLine($"What is the gender? {chicken.MaleOrFemale}! How many legs do they have? {chicken.SetOfLegs}! What type of animal is this? {chicken.TypeOfAnimal}! Does it have a tail? {chicken.HaveATail}!");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             * 
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptile()
            {
                MaleOrFemale = "female",
                SetOfLegs = 4,
                TypeOfAnimal = "reptile",
                HaveATail = true,

                TypeOfSkin = "dry skin",
                CanSwim = true,
                Carnivore = true,
                UglyOrNah = "ugly"
            };
            Console.WriteLine($"How is their skin? {lizard.TypeOfSkin}! Can they swim? {lizard.CanSwim}! Do they eat meat & veggies? {lizard.Carnivore}! Is it ugly or nah? {lizard.UglyOrNah}");
            Console.WriteLine($"What is the gender? {lizard.MaleOrFemale}! How many legs do they have? {lizard.SetOfLegs}! What type of animal is this? {lizard.TypeOfAnimal}! Does it have a tail? {lizard.HaveATail}!");
        }
    }
}
