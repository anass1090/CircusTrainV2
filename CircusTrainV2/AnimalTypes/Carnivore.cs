using CircusTrainV2.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainV2.AnimalTypes
{
    public class Carnivore : IAnimal
    {
        public Sizes Size { get; set; }

        public Carnivore(Sizes size)
        {
            this.Size = size;
        }

        public bool WillEat(IAnimal animal)
        {
            if (animal.Size <= Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
