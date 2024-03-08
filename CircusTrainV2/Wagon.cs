using CircusTrainV2.AnimalTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainV2
{
    public class Wagon
    {
        public List<IAnimal> animalsInWagon;
        private readonly int size;

        private int availableSpace
        {
            get
            {
                int space = size;

                for (int i = 0; i < animalsInWagon.Count; i++)
                {
                    space -= (int)animalsInWagon[i].Size;
                }

                return space;
            }
        }

        public Wagon()
        {
            animalsInWagon = new List<IAnimal>();
            size = 10;
        }

        public bool TryAddingAnimal(IAnimal animal)
        {
            if (availableSpace >= (int)animal.Size)
            {
                foreach (IAnimal animalInWagon in animalsInWagon)
                {
                    if (animalInWagon.WillEat(animal) || animal.WillEat(animalInWagon))
                    {
                        return false;
                    }
                }

                animalsInWagon.Add(animal);                                     
                return true;
            }

            return false;                                                                                                  
        }
    }
}
    