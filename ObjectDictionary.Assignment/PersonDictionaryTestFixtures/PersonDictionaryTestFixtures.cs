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
            var personDictionary=_personDictionary.AddPerson(new Person("Ravneet", "Nauhwar"), "Beautiful");
            personDictionary = _personDictionary.AddPerson(new Person("Vishwajeet", "Gandhok"), "Brute");
            personDictionary = _personDictionary.AddPerson(new Person("Ravneet", "Nauhwar"), "Beautiful");
            Assert.IsNotNull(personDictionary);
            Assert.IsTrue(personDictionary.Count == 2);
        }
    }
}
