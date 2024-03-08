using CircusTrainV2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainV2.AnimalTypes
{
    public class Herbivore : IAnimal
    {
        public Sizes Size { get; set; }

        public Herbivore(Sizes size)
        {
            this.Size = size;
        }

        public bool WillEat(IAnimal animal)
        {
            return false;
        }
    }
}
