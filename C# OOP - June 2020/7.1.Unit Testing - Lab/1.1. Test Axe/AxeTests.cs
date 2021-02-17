using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;

        [SetUp]
        public void SetUp()
        {
            this.axe = new Axe(5, 10);
        }

        [Test]
        public void TestConstrucor()
        {
            int currentAttack = 5;
            int expectedAttack = this.axe.AttackPoints;

            Assert.That(expectedAttack == currentAttack);
        }

        [Test]
        public void TestConstrucor1()
        {
            int currentAttack = 10;
            int expectedAttack = this.axe.DurabilityPoints;

            Assert.That(expectedAttack == currentAttack);
        }

        [Test]
        public void ThrowsException()
        {
            var newAxe = new Axe(10, 0);

            Assert.Throws<InvalidOperationException>(() => newAxe.Attack(new Dummy(50, 50)), "Axe is broken.");
        }
        [Test]
        public void AttackMethod()
        {
            var dummy = new Dummy(10, 10);

            this.axe.Attack(dummy);

            Assert.That(this.axe.DurabilityPoints == 9);
        }
    }
}
