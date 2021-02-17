using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;
        [SetUp]
        public void SetUp()
        {
            this.dummy = new Dummy(10, 10);
        }

        [Test]
        public void TestConstructorHealth()
        {
            Assert.That(this.dummy.Health == 10);
        }

        [Test]
        public void TestTakeAttackMethod()
        {
            var test = new Dummy(0, 10);

            Assert.Throws<InvalidOperationException>(() => test.TakeAttack(10), "Dummy is dead.");
        }

        [Test]
        public void TestTakeAttackMethod1()
        {
            var test = new Dummy(20, 10);

            test.TakeAttack(10);

            Assert.That(test.Health == 10);
        }

        [Test]
        public void TestGiveExpMethod()
        {
            Assert.Throws<InvalidOperationException>(() => this.dummy.GiveExperience(), "Target is not dead.");
        }

        [Test]
        public void TestReturnExp()
        {
            var test = new Dummy(0, 10);

            Assert.That(test.GiveExperience() == 10);
        }

        [Test]
        public void TestReturnExp1()
        {
            var test = new Dummy(0, 10);

            Assert.IsTrue(test.IsDead());
        }
    }
}
