using CircusTrainV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace CircusTrainUnitTest
{
    [TestClass]
    public class UnitTestScenarios
    {
        readonly Case testCase = new Case();
        readonly AnimalPlacer placeAnimals = new AnimalPlacer();

        [TestMethod]
        public void Scenario1()
        {
            List<IAnimal> animals = testCase.Scenario(1, 0, 0, 0, 3, 2);
            Train train = placeAnimals.AllocateAnimalsToTrain(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario2()
        {
            List<IAnimal> animals = testCase.Scenario(1, 0, 0, 5, 2, 1);
            Train train = placeAnimals.AllocateAnimalsToTrain(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario3()
        {
            List<IAnimal> animals = testCase.Scenario(1, 1, 1, 1, 1, 1);
            Train train = placeAnimals.AllocateAnimalsToTrain(animals);

            Assert.AreEqual(4, train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario4()
        {
            List<IAnimal> animals = testCase.Scenario(2, 1, 1, 1, 5, 1);
            Train train = placeAnimals.AllocateAnimalsToTrain(animals);

            Assert.AreEqual(5, train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario5()
        {
            List<IAnimal> animals = testCase.Scenario(1, 0, 0, 1, 1, 2);
            Train train = placeAnimals.AllocateAnimalsToTrain(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario6()
        {
            List<IAnimal> animals = testCase.Scenario(3, 0, 0, 0, 2, 3);
            Train train = placeAnimals.AllocateAnimalsToTrain(animals);

            Assert.AreEqual(3, train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario7()
        {
            List<IAnimal> animals = testCase.Scenario(7, 3, 3, 0, 5, 6);
            Train train = placeAnimals.AllocateAnimalsToTrain(animals);

            Assert.AreEqual(13, train.Wagons.Count);
        }

        [TestMethod]
        public void Scenario8()
        {
            List<IAnimal> animals = testCase.Scenario(0, 0, 0, 0, 0, 0);
            Train train = placeAnimals.AllocateAnimalsToTrain(animals);

            Assert.AreEqual(0, train.Wagons.Count);
        }
    }
}

