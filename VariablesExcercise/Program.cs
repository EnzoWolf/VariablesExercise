using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExcercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Allocating values to variables

            string dogName = "Ender";
            int ageOfDog = 8;
            char nameFirstLetter = 'E';
            bool firstPet = false;
            double ageInHumanYrs = 51.5;
            decimal dogWeight = 44.8m;

            Console.WriteLine($"My dog's name is {dogName}, and I got him {ageOfDog} years ago. The first letter of his name is {nameFirstLetter}.");
            Console.WriteLine($"I would say he is my first dog, but that would be {firstPet}.");
            Console.WriteLine($"{dogName}'s true age in human years is {ageInHumanYrs}. Lastly, {dogName} is {dogWeight} lbs.");

        }
    }
}
