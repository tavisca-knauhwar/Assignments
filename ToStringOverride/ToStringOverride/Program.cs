using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Kuldeep", "Nauhwar");
            Console.WriteLine(person.ToString());
            Console.ReadLine();
        }

        public class Person
        {
            private string _firstName;
            private string _lastName;

            public Person(string firstName, string lastName)
            {
                _firstName = firstName;
                _lastName = lastName;
            }

            public override string ToString()
            {
                return string.Format("{0} {1}",_firstName,_lastName);
            }
        }
    }
}
