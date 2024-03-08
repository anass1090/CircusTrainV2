using CircusTrainV2.AnimalTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CircusTrainV2.Enums;
using CircusTrainV2;

namespace CircusTrainUnitTest
{
    [TestClass]
    public class UnitTestPublicFunctions
    {
        [TestMethod]
        public void AnyHerbivoreShouldNotEatAnyAnimal()
        {
            Herbivore herbivoreSmall = new Herbivore(Sizes.small);
            Herbivore herbivoreMedium = new Herbivore(Sizes.medium);
            Herbivore herbivoreLarge = new Herbivore(Sizes.large);

            Carnivore carnivoreSmall = new Carnivore(Sizes.small);
            Carnivore carnivoreMedium = new Carnivore(Sizes.medium);
            Carnivore carnivoreLarge = new Carnivore(Sizes.large);

            Assert.IsFalse(
                herbivoreSmall.WillEat(carnivoreSmall) &&
                herbivoreSmall.WillEat(carnivoreMedium) &&
                herbivoreSmall.WillEat(carnivoreLarge) &&
                herbivoreMedium.WillEat(carnivoreSmall) &&
                herbivoreMedium.WillEat(carnivoreMedium) &&
                herbivoreMedium.WillEat(carnivoreLarge) &&
                herbivoreLarge.WillEat(carnivoreSmall) &&
                herbivoreLarge.WillEat(carnivoreMedium) &&
                herbivoreLarge.WillEat(carnivoreLarge) &&
                herbivoreSmall.WillEat(herbivoreSmall) &&
                herbivoreSmall.WillEat(herbivoreMedium) &&
                herbivoreSmall.WillEat(herbivoreLarge) &&
                herbivoreMedium.WillEat(herbivoreSmall) &&
                herbivoreMedium.WillEat(herbivoreMedium) &&
                herbivoreMedium.WillEat(herbivoreLarge) &&
                herbivoreLarge.WillEat(herbivoreSmall) &&
                herbivoreLarge.WillEat(herbivoreMedium) &&
                herbivoreLarge.WillEat(herbivoreLarge)
                );
        }

        [TestMethod]
        public void AnyCarnivoreShouldEatAnySmallerOrSamesizedAnimal()
        {
            Herbivore herbivoreSmall = new Herbivore(Sizes.small);
            Herbivore herbivoreMedium = new Herbivore(Sizes.medium);
            Herbivore herbivoreLarge = new Herbivore(Sizes.large);

            Carnivore carnivoreSmall = new Carnivore(Sizes.small);
            Carnivore carnivoreMedium = new Carnivore(Sizes.medium);
            Carnivore carnivoreLarge = new Carnivore(Sizes.large);

            Assert.IsTrue(
                carnivoreMedium.WillEat(carnivoreSmall) &&
                carnivoreMedium.WillEat(carnivoreMedium) &&
                carnivoreMedium.WillEat(herbivoreSmall) &&
                carnivoreMedium.WillEat(herbivoreMedium) &&
                carnivoreLarge.WillEat(carnivoreSmall) &&
                carnivoreLarge.WillEat(carnivoreMedium) &&
                carnivoreLarge.WillEat(carnivoreLarge) &&
                carnivoreLarge.WillEat(herbivoreSmall) &&
                carnivoreLarge.WillEat(herbivoreMedium) &&
                carnivoreLarge.WillEat(herbivoreLarge)
            );
        }

        [TestMethod]
        public void AnyCarnivoreShouldNotEatAnyBiggerAnimal()
        {
            Herbivore herbivoreMedium = new Herbivore(Sizes.medium);
            Herbivore herbivoreLarge = new Herbivore(Sizes.large);

            Carnivore carnivoreSmall = new Carnivore(Sizes.small);
            Carnivore carnivoreMedium = new Carnivore(Sizes.medium);
            Carnivore carnivoreLarge = new Carnivore(Sizes.large);

            Assert.IsFalse(
                carnivoreMedium.WillEat(carnivoreLarge) &&
                carnivoreMedium.WillEat(herbivoreLarge) &&
                carnivoreSmall.WillEat(carnivoreMedium) &&
                carnivoreSmall.WillEat(carnivoreLarge) &&
                carnivoreSmall.WillEat(herbivoreMedium) &&
                carnivoreSmall.WillEat(herbivoreLarge)
            );
        }

        [TestMethod]
        public void AnyAnimalShouldBeAbleToBeAddedToEmptyWagon()
        {
            Herbivore herbivoreSmall = new Herbivore(Sizes.small);
            Herbivore herbivoreMedium = new Herbivore(Sizes.medium);
            Herbivore herbivoreLarge = new Herbivore(Sizes.large);

            Carnivore carnivoreSmall = new Carnivore(Sizes.small);
            Carnivore carnivoreMedium = new Carnivore(Sizes.medium);
            Carnivore carnivoreLarge = new Carnivore(Sizes.large);

            bool AddAnimalToNewWagon(IAnimal animal)
            {
                Wagon wagon = new Wagon();
                return wagon.TryAddingAnimal(animal);
            }

            Assert.IsTrue(
                AddAnimalToNewWagon(carnivoreSmall) &&
                AddAnimalToNewWagon(carnivoreMedium) &&
                AddAnimalToNewWagon(carnivoreLarge) &&
                AddAnimalToNewWagon(herbivoreSmall) &&
                AddAnimalToNewWagon(herbivoreMedium) &&
                AddAnimalToNewWagon(herbivoreLarge)
            );
        }

        [TestMethod]
        public void LargeHerbivoreShouldBeAbleToBeAddedToWagonWithMediumCarnivore()
        {
            Herbivore herbivoreLarge = new Herbivore(Sizes.large);
            Carnivore carnivoreMedium = new Carnivore(Sizes.medium);

            Wagon wagon = new Wagon();

            wagon.TryAddingAnimal(carnivoreMedium);
            wagon.TryAddingAnimal(herbivoreLarge);

            Assert.IsTrue(
                wagon.animalsInWagon.Contains(carnivoreMedium) &&
                wagon.animalsInWagon.Contains(herbivoreLarge)
            );
        }

        [TestMethod]
        public void LargeHerbivoreShouldNotBeAbleToBeAddedToWagonWithNotEnoughSpace()
        {
            Herbivore herbivoreLarge = new Herbivore(Sizes.large);
            Herbivore herbivoreMedium = new Herbivore(Sizes.medium);
            Carnivore carnivoreSmall = new Carnivore(Sizes.small);
            Wagon wagon = new Wagon();

            wagon.TryAddingAnimal(carnivoreSmall);
            wagon.TryAddingAnimal(herbivoreMedium);
            wagon.TryAddingAnimal(herbivoreMedium);
            wagon.TryAddingAnimal(herbivoreLarge);

            Assert.IsFalse(
                wagon.animalsInWagon.Contains(herbivoreLarge)
            );
        }

        [TestMethod]
        public void MediumHerbivoreShouldNotBeAbleToBeAddedToWagonWithMediumCarnivore()
        {
            Herbivore herbivoreMedium = new Herbivore(Sizes.medium);
            Carnivore carnivoreMedium = new Carnivore(Sizes.medium);
            Wagon wagon = new Wagon();

            wagon.TryAddingAnimal(carnivoreMedium);
            wagon.TryAddingAnimal(herbivoreMedium);

            Assert.IsFalse(
                wagon.animalsInWagon.Contains(herbivoreMedium)
            );
        }

        [TestMethod]
        public void SmallHerbivoreShouldBeAbleToBeAddedToWagonWithThreeMediumHerbivores()
        {
            Herbivore herbivoreSmall = new Herbivore(Sizes.small);
            Herbivore herbivoreMedium = new Herbivore(Sizes.medium);
            Wagon wagon = new Wagon();

            wagon.TryAddingAnimal(herbivoreMedium);
            wagon.TryAddingAnimal(herbivoreMedium);
            wagon.TryAddingAnimal(herbivoreMedium);
            wagon.TryAddingAnimal(herbivoreSmall);

            Assert.IsTrue(
                wagon.animalsInWagon.Contains(herbivoreSmall)
            );
        }
    }
}
