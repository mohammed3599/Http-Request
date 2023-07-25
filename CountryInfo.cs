using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequest
{
    internal class CountryInfo
    {
        String officialName;
        String capital;
        Double area;

        public CountryInfo(String officialName, String capital, Double area)
        {
            this.officialName = officialName;
            this.capital = capital;
            this.area = area;
        }
    }
}
