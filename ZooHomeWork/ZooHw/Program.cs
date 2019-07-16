using System;

namespace ZooHw
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------ZOOS---------------
            Zoo zoo1 = new Zoo("Barlad");
            Zoo zoo2 = new Zoo("Iasi");
            Zoo zoo3 = new Zoo("Brasov");

            //---------------ANIMALS---------------

            Animals animal1 = new Animals("Jake", AnimalType.MammalsCarnivores,new DateTime(1984,12,25),FavoriteFood.Meat );
            Animals animal2 = new Animals("Mike", AnimalType.MammalsCarnivores,new DateTime(1985,11,26),FavoriteFood.Fish );
            Animals animal3 = new Animals("Fluffy", AnimalType.BirdsBirdsOfPrey,new DateTime(1986,10,27),FavoriteFood.Meat );
            Animals animal4 = new Animals("Molly", AnimalType.ReptilesTurtles,new DateTime(1987,09,28),FavoriteFood.Fish );
            Animals animal5 = new Animals("Daisy", AnimalType.ReptilesLizards,new DateTime(1988,08,29),FavoriteFood.Grass );
            //---------------Some Actions-----------

            zoo1.AddAnimalsToZoos(animal1);
            zoo2.AddAnimalsToZoos(animal2);
            zoo3.AddAnimalsToZoos(animal3);
            zoo1.AddAnimalsToZoos(animal4);
            zoo3.AddAnimalsToZoos(animal5);

            Console.WriteLine("---------------LIST of ANIMALS at Zoos---------------\n");
            zoo1.PrintAnimalList();
            zoo2.PrintAnimalList();
            zoo3.PrintAnimalList();

            Console.WriteLine("---------------Transfers---------------\n");

            zoo2.TransferAnimal(zoo1, animal1);
                        zoo2.PrintAnimalList();
                        zoo1.PrintAnimalList();
            Console.WriteLine("---------------Eating---------------\n");

            animal1.Eat();
            animal2.Eat();
            animal3.Eat();
            animal4.Eat();
            animal5.Eat();
        }
    }
}
