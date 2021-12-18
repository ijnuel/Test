using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coure_Assessment.Abstractions.Repositories;
using Coure_Assessment.Data;
using Coure_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Coure_Assessment.Implementations.Repositories
{
    public class CountryRepo : ICountryRepo
    {
        private ApplicationDBContext _context;

        public CountryRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        public Country GetCountryDetails(string countryCode)
        {
            return _context.Country
                .Where(x => x.CountryCode == countryCode)
                .Include(x => x.CountryDetails)
                .FirstOrDefault();
        }
    }
}
