using NUnit.Framework;

namespace Tests
{
    //using ExtendedDatabase;
    using System;

    public class ExtendedDatabaseTests
    {
        private Person person;
        private ExtendedDatabase database;


        [SetUp]
        public void Setup()
        {
            this.person = new Person(100, "niki");
            this.database = new ExtendedDatabase();

        }

        [Test]
        public void PersonId()
        {
            Assert.That(this.person.Id == 100); ;
        }

        [Test]
        public void PersonUserName()
        {
            Assert.That(this.person.UserName == "niki");
        }

        [Test]
        public void DataBase()
        {
            Assert.That(this.database.Count == 0);
        }

        [Test]
        public void DataBaseAddRangeThrows()
        {
            Person[] people = new Person[17];

            for (int i = 0; i < 17; i++)
            {
                people[i] = new Person(i + 1, "nick" + i);
            }

            Assert.Throws<ArgumentException>(() => new ExtendedDatabase(people));
        }
        [Test]
        public void DataBaseAddRangeWorkCorrectly()
        {
            Person[] people = new Person[16];

            for (int i = 0; i < 16; i++)
            {
                people[i] = new Person(i + 1, "nick" + i);
            }

            this.database = new ExtendedDatabase(people);

            Assert.That(this.database.Count == 16);
        }

        [Test]
        public void DataBaseAddThrows1()
        {
            Person[] people = new Person[16];

            for (int i = 0; i < 16; i++)
            {
                people[i] = new Person(i + 1, "nick" + i);
            }

            this.database = new ExtendedDatabase(people);

            Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(123, "da")));
        }

        [Test]
        public void DataBaseAddThrows2()
        {
            Person[] people = new Person[15];

            for (int i = 0; i < 15; i++)
            {
                people[i] = new Person(i + 1, "nick" + i);
            }

            this.database = new ExtendedDatabase(people);

            Assert.Throws<InvalidOperationException>
                (() => this.database.Add(new Person(333, "nick" + 2)));
        }

        [Test]
        public void DataBaseAddThrows3()
        {
            Person[] people = new Person[15];

            for (int i = 0; i < 15; i++)
            {
                people[i] = new Person(i + 1, "nick" + i);
            }

            this.database = new ExtendedDatabase(people);

            Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(3, "nick")));
        }

        [Test]
        public void DataBaseAddThrows4()
        {
            Person[] people = new Person[15];

            for (int i = 0; i < 15; i++)
            {
                people[i] = new Person(i + 1, "nick" + i);
            }

            this.database = new ExtendedDatabase(people);

            this.database.Add(new Person(17, "nik"));

            Assert.That(this.database.Count == 16);
        }

        [Test]
        public void DataBaseRemove()
        {
            this.database = new ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }

        [Test]
        public void DataBaseRemove1()
        {
            Person[] people = new Person[2];

            this.database.Add(new Person(123, "da"));
            this.database.Add(new Person(1243, "as"));

            this.database.Remove();

            Assert.That(this.database.Count == 1);
        }

        [Test]
        public void DataBaseFindByUserNameNull()
        {
            Person[] people = new Person[15];

            for (int i = 0; i < 15; i++)
            {
                people[i] = new Person(i + 1, "nick" + i);
            }

            this.database = new ExtendedDatabase(people);

            Assert.Throws<ArgumentNullException>(() => this.database.FindByUsername(null));
        }

        [Test]
        public void DataBaseFindByUserNameInvalidUser()
        {
            Person[] people = new Person[15];

            for (int i = 0; i < 15; i++)
            {
                people[i] = new Person(i + 1, "nick" + i);
            }

            this.database = new ExtendedDatabase(people);

            Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername("dsadad"));
        }

        [Test]
        public void DataBaseFindByUserNameInvalidUser1()
        {


            this.database.Add(this.person);

            Assert.AreEqual(this.person, this.database.FindByUsername("niki"));
        }

        [Test]
        public void DataBaseFindByID()
        {
            this.database.Add(this.person);

            Assert.Throws<ArgumentOutOfRangeException>(() => this.database.FindById(-1));
        }

        [Test]
        public void DataBaseFindByID1()
        {
            this.database.Add(this.person);

            Assert.Throws<InvalidOperationException>(() => this.database.FindById(0));
        }

        [Test]
        public void DataBaseFindByID2()
        {
            this.database.Add(this.person);

            Assert.AreEqual(this.person, this.database.FindById(100));
        }
    }
}