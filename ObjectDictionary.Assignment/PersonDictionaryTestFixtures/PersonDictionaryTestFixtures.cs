using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectDictionary.Assignment;

namespace PersonDictionaryTests
{
    [TestClass]
    public class PersonDictionaryTestFixtures
    {
        private PersonDictionary _personDictionary;

        [TestInitialize]
        public void Initialize()
        {
            _personDictionary = new PersonDictionary();
        }

        [TestMethod]
        public void AddPersonDictionaryTest()
        {
            var personDictionary = _personDictionary.AddPerson(new Person("Ravnit", "Nauhwar"), "Smart");
            Assert.IsNotNull(personDictionary);
        }

        [TestMethod]
        public void AddDuplicatPersonDictionaryTest()
        {
            var personDictionary=_personDictionary.AddPerson(new Person("Ravnit", "Nauhwar"), "Smart");
            personDictionary = _personDictionary.AddPerson(new Person("Ravnit", "Nauhwar"), "Smart");
            Assert.IsTrue(personDictionary.Count == 1);
        }

        [TestMethod]
        public void UpdatePersonDictionaryTest()
        {
            var personDictionary = _personDictionary.AddPerson(new Person("Ravnit", "Nauhwar"), "Smart");
            personDictionary = _personDictionary.UpdatePerson(new Person("Ravnit", "Nauhwar"), "Intelligent");
            Assert.IsTrue(string.Equals(personDictionary[new Person("Ravnit", "Nauhwar")], "Intelligent", System.StringComparison.OrdinalIgnoreCase));
        }

        [TestMethod]
        public void UpdatePersonDictionaryAddTest()
        {
            var person = new Person("Ravnit", "Nauhwar");
            var personDictionary = _personDictionary.AddPerson(person, "Smart");
            personDictionary = _personDictionary.UpdatePerson(new Person("Kuldeep","Nauhwar"), "Intelligent");
            Assert.IsTrue(string.Equals(personDictionary[person], "smart", System.StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(personDictionary.Count == 2);
        }

        [TestMethod]
        public void RemovePersonDictionaryTest()
        {
            var person = new Person("Ravnit", "Nauhwar");
            var personDictionary = _personDictionary.AddPerson(person, "Smart");
            personDictionary = _personDictionary.RemovePerson(new Person("Ravnit", "Nauhwar"));
            Assert.IsTrue(personDictionary.Count == 0);
        }

        [TestMethod]
        public void RemovePersonFromEmptyDictionaryTest()
        {
            var personDictionary = _personDictionary.RemovePerson(new Person("Ravnit", "Nauhwar"));
            Assert.IsTrue(personDictionary.Count == 0);
        }
    }
}
