using System;
using System.Collections.Generic;
using System.Text;

namespace ZooHw
{
    class Zoo
    {

        private string zooName;
        private Dictionary<string, string> animalsList = new Dictionary<string, string>();
        public static string animalName;
        private string favoriteFood;
        public static int contor;

        public Zoo(string name)
        {
            this.zooName = name;
        }

        public Dictionary<string, string> AnimalsList
        {
            get
            {
                return this.animalsList;
            }
        }

        public void Eat()
        { }

        static void AddAnimal()
        {
            animalName = "";
            contor = 0;
        }

        public void AddAnimal(string name, string food)
        {
            animalName = name;
            this.favoriteFood = food;
            contor++;
            this.animalsList.Add(name, food);
        }

        public static int GetContor()
        {
            return contor;
        }

        public void Transfer(string animal)
        {
            if (this.AnimalsList.ContainsKey(animal))
            {
                Console.Write(this.AnimalsList.Remove(animal));
                contor--;
            }
            else
            {
                Console.WriteLine("We don't have this animal in our garden, he was transfered.");
            }

        }

        public void PresentZoo()
        {
            int num = 1;
            Console.WriteLine("In our ZOO " + this.zooName + " we have " + contor + " animals, ordered like this: ");
            foreach (var animal in this.AnimalsList)
            {
                Console.WriteLine(num + ". " + animal.Key + ", prefers to eat " + animal.Value);
                num++;
            }

        }

    }
}
