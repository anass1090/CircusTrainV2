using CircusTrainV2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainV2
{
    public interface IAnimal
    {
        Sizes Size { get; set; }
        
        bool WillEat(IAnimal animal);
    }
}
