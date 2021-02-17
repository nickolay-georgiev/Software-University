using NUnit.Framework;

namespace Tests
{
    //using Database;
    using System;
    public class DatabaseTests
    {
        private Database database; 

        [SetUp]
        public void Setup()
        {
            this.database = new Database(new int[16]);
        }

        [Test]
        public void TestConstructor()
        {
            Assert.That(this.database.Count == 16);
        }
        [Test]
        public void TestAdd()
        {
            Assert.Throws<InvalidOperationException>(() => this.database.Add(5), "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void TestAdd1()
        {
            var test = new Database(new int[2] { 1, 2 });
            test.Add(4);
            test.Add(5);

            Assert.That(test.Count == 4);
        }

        [Test]
        public void TestRemoveThrows()
        {
            var test = new Database(new int[1]);
            test.Remove();

            Assert.Throws<InvalidOperationException>(() => test.Remove(), "The collection is empty!");
        }
        [Test]
        public void TestRemove()
        {
            var test = new Database(new int[2] { 1,2});
            test.Remove();

            Assert.That(test.Count == 1);
        }

        [Test]
        public void TestFetch()
        {
            var test = new Database(new int[2] { 1, 2 });
            test.Add(4);
            test.Add(5);

            var temp = test.Fetch();

            Assert.That(test.Count == temp.Length);
        }

        //[Test]
        //public void TestFetch1()
        //{
        //    var test = new Database(new int[2] { 1, 2 });
        //    test.Add(4);
        //    test.Add(5);

        //    var temp = test.Fetch();

        //    CollectionAssert.AreEqual(test.Fetch(), temp);
        //}
    }
}