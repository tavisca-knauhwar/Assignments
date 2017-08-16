using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Immutability.Assignment
{
    public class Currency
    {
        private readonly string _counrtyName;

        private readonly string _countryCurrency;

        private readonly string _currencyName;

        public string CountryName
        {
            get
            {
                return _counrtyName;
            }
        }
        public string CountryCurrency
        {
            get
            {
                return _countryCurrency;
            }
        }

        public string CurrencyName
        {

            get
            {
                return _countryCurrency;
            }
        }

        public Currency(string countryName, string countryCurrency, string currencyName)
        {
            _counrtyName = countryName;
            _countryCurrency = countryCurrency;
            _currencyName = currencyName;
        }

        public Currency ToUpper(Currency currency)
        {
            if (currency == null)
                return null;

            return new Currency(currency.CountryName.ToUpper(), currency.CountryCurrency.ToUpper(), currency.CurrencyName.ToUpper()); 
        }

    }
}
