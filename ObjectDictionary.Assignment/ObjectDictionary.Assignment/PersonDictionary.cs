using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDictionary.Assignment
{
    public class PersonDictionary
    {
       public Dictionary<Person, string> PersonDict { get; set; }

        public PersonDictionary()
        {
            PersonDict = new Dictionary<Person, string>();
        }

        public Dictionary<Person, string> AddPerson(Person person, string quality)
        {
            if (IsExists(person, quality))
                return PersonDict;
            PersonDict.Add(person, quality);
            return PersonDict;
        }

        private bool IsExists(Person person, string quality)
        {
            foreach (var individual in PersonDict)
            {
                if (individual.Key.Equals(person))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
