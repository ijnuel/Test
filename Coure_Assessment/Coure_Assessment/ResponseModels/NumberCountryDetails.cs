using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coure_Assessment.Models;

namespace Coure_Assessment.ResponseModels
{
    public class NumberCountryDetails
    {
        public string Number { get; set; }
        public CountryResponse Country { get; set; }
    }

    public class CountryResponse
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetailsResponse> CountryDetails { get; set; }
    }

    public class CountryDetailsResponse
    {
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
