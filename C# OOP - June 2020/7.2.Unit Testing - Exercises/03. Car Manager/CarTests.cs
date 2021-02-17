using NUnit.Framework;
using System;

namespace Tests
{
    //using CarManager;
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            this.car = new Car("Honda", "Civik", 10, 100);
        }


        [Test]
        public void AssureThatMakeSetsProperly()
        {
            Assert.That(this.car.Make == "Honda");
        }

        [Test]
        public void AssureThatModelSetsProperly()
        {
            Assert.That(this.car.Model == "Civik");
        }

        [Test]
        public void AssureThatFuelConsumptionSetsProperly()
        {
            Assert.That(this.car.FuelConsumption == 10);
        }

        [Test]
        public void AssureThatFuelCapacitySetsProperly()
        {
            Assert.That(this.car.FuelCapacity == 100);
        }

        [Test]
        public void AssureThatFuelAmountSetsProperly()
        {
            Assert.That(this.car.FuelAmount == 0);
        }

        [Test]
        public void AssureThatThrowsWithNullOrEmtyMake()
        {
            Assert.Throws<ArgumentException>(() => new Car(null, "civik", 10, 10), "Make cannot be null or empty!");
        }

        [Test]
        public void AssureThatThrowsWithNullOrEmtyModel()
        {
            Assert.Throws<ArgumentException>(() => new Car("honda", null, 10, 10), "Model cannot be null or empty!");
        }

        [Test]
        public void AssureThatThrowsWithZerpFuelConsumtion()
        {
            Assert.Throws<ArgumentException>(() => new Car("honda", "civik", 0, 10), "Fuel consumption cannot be zero or negative!");
        }

        [Test]
        public void AssureThatThrowsWithZeroCapacity()
        {
            Assert.Throws<ArgumentException>(() => new Car("honda", "civik", 10, 0), "Fuel amount cannot be negative!");
        }

        [Test]
        public void TestRefuelMethod()
        {
            Assert.Throws<ArgumentException>(() => this.car.Refuel(0), "Fuel amount cannot be zero or negative!");
        }

        [Test]
        public void TestRefuelMethodWorksCorectly()
        {
            this.car.Refuel(10);

            Assert.That(car.FuelAmount == 10);
        }

        [Test]
        public void TestRefuelMethodWorksCorectly1()
        {
            this.car.Refuel(1000);

            Assert.That(car.FuelAmount == 100);
        }

        [Test]
        public void TestDriveMethodWorksCorectly()
        {

            Assert.Throws<InvalidOperationException>(() => this.car.Drive(100000), "You don't have enough fuel to drive!");
        }

        [Test]
        public void TestDriveMethodWorksCorectly1()
        {

            this.car.Refuel(20);
            this.car.Drive(100);

            Assert.That(this.car.FuelAmount == 10);
        }


    }
}