using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Assignment.Test
{
   public static class DataSource
    {
        private static Random random = new Random();
        public static Person GetPerson()
        {
            return new Person("Ravnit","Nauhwar");
        }

        public static Person GetRandomPerson()
        {
            return new Person(RandomString(8), RandomString(8));
        }

        
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
