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
        private readonly Dictionary<string, string> _countriesCurrency;
        public  Dictionary<string, string> CountriesCurrency { get { return _countriesCurrency; } }

        public Currency()
        {
            _countriesCurrency = new Dictionary<string, string>();
            var doc = XDocument.Load(@"D:\GIT\Assignments\Immutability.Assignment\Immutability.Assignment\CountiresCurrency.xml");
            var countries = doc.Root.Elements().Select(x => x.Element("CtryNm"));
        }

    }
}
