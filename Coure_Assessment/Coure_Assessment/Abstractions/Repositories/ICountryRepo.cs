using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coure_Assessment.Models;

namespace Coure_Assessment.Abstractions.Repositories
{
    public interface ICountryRepo
    {
        public Country GetCountryDetails(string countryCode);
    }
}
