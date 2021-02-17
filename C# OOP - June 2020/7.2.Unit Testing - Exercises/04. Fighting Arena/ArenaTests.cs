using NUnit.Framework;
using System;

namespace Tests
{
    //using FightingArena;
    using System.Collections.Generic;

    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
        }

        [Test]
        public void TestEnrollCommand()
        {
            var warrior = new Warrior("ivan", 100, 100);

            this.arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() => this.arena.Enroll(warrior));
        }

        [Test]
        public void EmptyCollection()
        {
            CollectionAssert.IsEmpty(this.arena.Warriors);
        }

        [Test]
        public void TestEnrollCommand1()
        {
            var warrior = new Warrior("iva", 100, 100);
            var warrior1 = new Warrior("ivan", 100, 100);

            this.arena.Enroll(warrior);
            this.arena.Enroll(warrior1);

            Assert.That(this.arena.Count == 2);
        }

        [Test]
        public void TestFightCommand1()
        {
            var warrior = new Warrior("iva", 100, 100);
            var warrior1 = new Warrior("ivan", 100, 100);

            this.arena.Enroll(warrior);
            this.arena.Enroll(warrior1);

            Assert.Throws<InvalidOperationException>(() => this.arena.Fight(null, "ivan"));
        }

        [Test]
        public void TestFightCommand2()
        {
            var warrior = new Warrior("iva", 100, 100);
            var warrior1 = new Warrior("ivan", 100, 100);

            this.arena.Enroll(warrior);
            this.arena.Enroll(warrior1);

            Assert.Throws<InvalidOperationException>(() => this.arena.Fight("ivan", null));
        }

        [Test]
        public void TestCount()
        {
            Assert.That(this.arena.Count == 0);
        }

        [Test]
        public void TestCollection()
        {

            var warrior = new Warrior("iva", 100, 200);
            var warrior1 = new Warrior("ivan", 100, 200);

            List<Warrior> test = new List<Warrior>();

            test.Add(warrior);
            test.Add(warrior1);

            var testArena = new Arena();

            testArena.Enroll(warrior);
            testArena.Enroll(warrior1);

            var result = this.arena.Warriors;

            CollectionAssert.AreEqual(test, testArena.Warriors);
        }

        [Test]
        public void Fight_Correctly()
        {
            var first = new Warrior("gosho", 50, 100);
            var second = new Warrior("ivan", 40, 100);

            Arena arena1 = new Arena();
            arena1.Enroll(first);
            arena1.Enroll(second);

            arena1.Fight("gosho", "ivan");

            var expectedPeshoHp = 60;
            var actual = first.HP;
            Assert.AreEqual(expectedPeshoHp, actual);
        }
    }
}
