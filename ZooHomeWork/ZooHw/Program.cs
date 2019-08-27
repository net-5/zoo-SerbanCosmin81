using System;

namespace ZooHw
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo myZoo = new Zoo("ZOO Garden");
            myZoo.AddAnimal("squirl", "peanuts");
            myZoo.AddAnimal("wolf", "sheep");
            myZoo.AddAnimal("fox", "Chicken");
            myZoo.AddAnimal("lion", "antelope");
            myZoo.AddAnimal("elephant", "green leafs");
            myZoo.AddAnimal("deer", "hey");
            myZoo.AddAnimal("rabbit", "carrots");
            myZoo.AddAnimal("eagle", "mouses");
            myZoo.AddAnimal("monkey", "bannanas");
            myZoo.AddAnimal("snake", "mouses");
            myZoo.AddAnimal("groundhog", "nuts");
           
            myZoo.PresentZoo();

            Console.WriteLine("================================================");
            Console.WriteLine("Let's transfer the elephant!!!!");

            myZoo.Transfer("elephant");

            Console.WriteLine("\n================================================");
            myZoo.PresentZoo();
        }
    }
}
