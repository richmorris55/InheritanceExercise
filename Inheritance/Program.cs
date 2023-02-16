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


            Bird bird = new Bird();

            bird.breed = "cockatoo";

            bird.color = "white and yellow";

            bird.sound = "singing elvis";

            bird.legs = 2;

            bird.movement = "fly";

            bird.extinct = false;



            Console.WriteLine($"We have this beautiful {bird.breed} for sale! \n The bird has clipped wings so cannot {bird.movement}. \n People say this bird is on the verge of extinction but that is {bird.extinct}. \n The bird has {bird.legs} legs and is {bird.color}! \n  The coolest feature is that the bird loves {bird.sound} songs!");



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */


            Reptile reptile = new Reptile();

            reptile.size = "large, medium, and small";

            reptile.poisonous = true;

            reptile.demeanor = "aggressive or docile";

            reptile.legs = 0;

            reptile.age = "1 to 50 years old";

            reptile.skin = "scaly and shelly";

            Console.WriteLine($"Reptiles can vary from {reptile.size} in size and their skin can be {reptile.skin}.\n Reptiles can live from {reptile.age}. \n It is {reptile.poisonous} that some reptiles are poisonous while others are not.\n Some reptiles such as snakes have {reptile.legs} legs while reptiles such as lizards have 4 legs. \n Reptiles can be {reptile.demeanor} which depends on their brain composition. Some say crocodiles are angry cause they have all them teeth but no toothbrush, but scientists say its really because the medulla oblongata and limbic system.");





        }
    }
}
