using CircusTrainV2.AnimalTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainV2
{
    public class AnimalPlacer
    {
        public Train AllocateAnimalsToTrain(List<IAnimal> animalsToAdd)
        {
            List<Wagon> wagons = new List<Wagon>();

            List<Wagon> wagonsDesc = SortAndFitAnimals(animalsToAdd);
            List<Wagon> wagonsAsc = SortAndFitAnimals(animalsToAdd, false);


            if (wagonsDesc.Count < wagonsAsc.Count)
            {
                wagons.AddRange(wagonsDesc);
            }
            else
            {
                wagons.AddRange(wagonsAsc);
            }

            return new Train(wagons);
        }

        private List<Wagon> SortAndFitAnimals(List<IAnimal> animalsToAdd, bool isSizeDescending = true)
        {
            List<Wagon> wagons = new List<Wagon>();
            List<IAnimal> sortedAnimals;

            if (isSizeDescending)
            {
                sortedAnimals = SortByTypeAndSize(animalsToAdd);
            }
            else
            {
                sortedAnimals = SortByTypeAndSize(animalsToAdd, false);
            }

            foreach (IAnimal animal in sortedAnimals)
            {
                if (!TryAddingAnimalToWagons(animal, wagons))
                {
                    wagons.Add(CreateNewWagonWithAnimal(animal));
                }
            }

            return wagons;
        }

        private bool TryAddingAnimalToWagons(IAnimal animal, List<Wagon> wagons)
        {
            foreach (Wagon wagon in wagons)
            {
                if (wagon.TryAddingAnimal(animal))
                {
                    return true;
                }
            }

            return false;
        }

        private Wagon CreateNewWagonWithAnimal(IAnimal animal)
        {
            Wagon wagon = new Wagon();

            wagon.TryAddingAnimal(animal);
            return wagon;
        }

        private List<IAnimal> SortByTypeAndSize(List<IAnimal> animalsToAdd, bool isSizeDescending = true)
        {
            if(isSizeDescending)
            {
                animalsToAdd = animalsToAdd
                .OrderByDescending(a => a is Carnivore)
                .ThenBy(a => (int)a.Size)
                .ToList();
                return animalsToAdd;
            } 
            else
            {
                animalsToAdd = animalsToAdd
                .OrderByDescending(a => a is Carnivore)
                .ThenByDescending(a => (int)a.Size)
                .ToList();
                return animalsToAdd;
            }
            
        }
    }
}
