using System;
using System.Collections.Generic;
using System.Text;

namespace ZooHw
{
    public enum AnimalType
    {MammalMarsupials, MammalsCarnivores, MammalsPrimates ,BirdsBirdsOfPrey, BirdsParrots, BirdsOther,ReptilesCrocodilians, ReptilesTurtles, ReptilesLizards};

    public enum FavoriteFood {Apples, Meat, Bannans, Nuts, Fruits, Vegetables, Grass, Insects, ParrotFood,Fish, Lobsters };

    public enum AvailableZoos { Iasi, Barlad, Brasov}

    public class Animals
    {
        private AnimalType animalType;
        private string animalName;
        private DateTime birthDate;
        private FavoriteFood favouriteFood;
        
        public AnimalType AnimalType
        {
            get { return animalType; }
            private set { animalType = value; }
        }

        public string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            private set { birthDate = value; }
        }

        public FavoriteFood favoriteFood
        {
            get { return favouriteFood; }
            set { favouriteFood = value; }
        }
        public Animals (string pName, AnimalType pAnimalType, DateTime pBirthDate, FavoriteFood pFavouriteFood)
        {
            this.AnimalName = pName;
            this.AnimalType = pAnimalType;
            this.BirthDate = pBirthDate;
            this.favoriteFood = pFavouriteFood;
        }
        public string AnimalInfo()
        {
            return $"Name: I am {AnimalName}, from the class {animalType} born in: {BirthDate.Date.ToString("dd/MM/yyyy")}, favourite food: {favoriteFood}";
        }
        public void Eat()
        {
            Console.WriteLine($"My name is {AnimalName} and i like very much to eat {favoriteFood}.");
        }

    }
}
