﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainV2
{
    public class Train
    {
        public List<Wagon> Wagons { get; private set; }

        public Train(List<Wagon> wagons)
        {
            Wagons = wagons;
        }
    }
}
