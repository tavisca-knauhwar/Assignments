using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability.Assignment
{
   public class CurrencyDictionary
    {
        private readonly Dictionary<string, Currency> _currencyDictionary;

        public Dictionary<string, Currency> CurrencyCollection
        {
            get
            {
                return _currencyDictionary;
            }
        }

        public CurrencyDictionary()
        {
            _currencyDictionary = new Dictionary<string, Currency>();
            _currencyDictionary.Add("India", new Currency("India", "INR", "Indian Rupee"));
            _currencyDictionary.Add("USA", new Currency("United States of America", "USD", "U.S Dollar"));
            _currencyDictionary.Add("Russia", new Currency("RUSSIAN FEDERATION", "RUB", "Russian Ruble"));
        }

        public Currency GetCurrency(string country)
        {
            if (CurrencyCollection.ContainsKey(country) == false)
                return null;

            return CurrencyCollection[country];
        }
    }
}
