using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals = new List<Animal>();
        public Zoo(string Name, int capacity)
        {
            this.Name = Name;
            this.Capacity = capacity;

        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.animals.Count;
        public List<Animal> Animals => this.animals;

        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }

            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            if (Animals.Count + 1 > Capacity)
            {
                return "The zoo is full.";
            }
            Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";


        }

        public int RemoveAnimals(string species)
        {
            int counter = 0;
            var animals2 = Animals.ToList();
            foreach (var animal in animals2)
            {
                if(animal.Species == species)
                {
                    Animals.Remove(animal);
                    counter++;
                    //animals2 = Animals;
                }
            }
            
            return counter;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalss = new List<Animal>();
            foreach (var animal in Animals)
            {
                if (animal.Diet == diet)
                {
                    animalss.Add(animal);
                }
            }
            return animalss;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            Animal animall = null;
            var fish = this.animals.FirstOrDefault(e => e.Weight == weight);
            foreach (Animal item in Animals)
            {
                if(item.Weight == weight)
                {
                    animall = item;
                }
            }
            return animall;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int counter = 0;
            foreach(Animal item in Animals)
            {
                if(item.Length >= minimumLength && item.Length <= maximumLength)
                {
                    counter++;
                }
            }
            return $"There are {counter} animals with a length between {minimumLength} and {maximumLength} meters.";

        }



    }
}
