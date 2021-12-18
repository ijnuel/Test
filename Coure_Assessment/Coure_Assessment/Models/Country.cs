using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coure_Assessment.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetails> CountryDetails { get; set; }
    }
}
