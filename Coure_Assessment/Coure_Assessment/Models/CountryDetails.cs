using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coure_Assessment.Models
{
    public class CountryDetails
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
        public Country Country { get; set; }
    }
}
