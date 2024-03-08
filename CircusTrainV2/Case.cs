using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CircusTrainV2.AnimalTypes;
using CircusTrainV2.Enums;

namespace CircusTrainV2
{
    public class Case
    {
        public List<IAnimal> Scenario(int countSmallCarnivore, int countMediumCarnivore, int countLargeCarnivore, int countSmallHerbivore, int countMediumHerbivore, int countLargeHerbivore)
        {
            List<IAnimal> scenario = new List<IAnimal>();

            AddToScenario(scenario, Sizes.small, countSmallCarnivore, true);
            AddToScenario(scenario, Sizes.medium, countMediumCarnivore, true);
            AddToScenario(scenario, Sizes.large, countLargeCarnivore, true);
            AddToScenario(scenario, Sizes.small, countSmallHerbivore, false);
            AddToScenario(scenario, Sizes.medium, countMediumHerbivore, false);
            AddToScenario(scenario, Sizes.large, countLargeHerbivore, false);

            return scenario;
        }

        private void AddToScenario(List<IAnimal> scenario, Sizes size, int count, bool isCarnivore)
        {
            for (int i = 0; i < count; i++)
            {
                if (isCarnivore)
                {
                    scenario.Add(new Carnivore(size));
                } else
                {
                    scenario.Add(new Herbivore(size));
                }
            }
        }
    }
}
