using System;
using System.Collections.Generic;
using System.Text;

namespace ZooHw
{
    class Zoo : ITransfer
    {
        private string zooName;
        private List<Animals> animals; 

        public List<Animals> ListOfAnimals
        {
            get { return animals; }
            private set { animals = value; }
        }

        public string ZooName
        {
            get { return zooName; }
            private set { zooName = value; }
        }

        public Zoo(string pName)
        {
            ZooName = pName;
            this.ListOfAnimals = new List<Animals>();
        }
        public void PrintAnimalList()
        {
            Console.WriteLine($"The Zoo of {this.ZooName} have a number of {this.ListOfAnimals.Count} animals:\nList of animals:\n ");
            foreach (Animals animal in this.ListOfAnimals)
            {
                Console.WriteLine(animal.AnimalInfo());
            }
            Console.WriteLine();
        }

        public void TransferAnimal(Zoo zoo, Animals pAnimal)
        {
            zoo.ListOfAnimals.Add(pAnimal);
            this.ListOfAnimals.Remove(pAnimal);
            Console.WriteLine($"Tranfer FeedBack: \n{pAnimal.AnimalName} transfered from {this.ZooName} to {zoo.ZooName}");
        }

        public void AddAnimalsToZoos(Animals pAnimal)
        {
            this.ListOfAnimals.Add(pAnimal);
            Console.WriteLine($"This animal {pAnimal.AnimalName} was added to this Zoo {zooName}");
        }
    }
}
