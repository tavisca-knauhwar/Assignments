﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDictionary.Assignment
{
    public class Person
    {
        private string _firstName;

        private string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}",FirstName,LastName);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (this.GetType() != obj.GetType())
                return false;

            var person = obj as Person;

            if (person == null)
                return false;

            if (this.GetHashCode() == person.GetHashCode())
                return true;

            if (string.Equals(this.ToString(), person.ToString(), StringComparison.OrdinalIgnoreCase))
                return true;


            return false;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() * 5 + this.LastName.GetHashCode();
        }
    }
}
