using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Coure_Assessment.Abstractions;
using Coure_Assessment.Abstractions.Repositories;
using Coure_Assessment.Data;
using Coure_Assessment.Implementations.Repositories;

namespace Coure_Assessment.Implementations
{
    public class Services : IServices
    {
        private readonly ApplicationDBContext _context;

        public Services(ApplicationDBContext context, IMapper autoMapper)
        {
            _context = context;
            Mapper = autoMapper;
            Country = new CountryRepo(_context);
        }

        public ICountryRepo Country { get; set; }
        public IMapper Mapper { get; set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public bool VerifyPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length < 3)
            {
                return false;
            }
            foreach (char c in phoneNumber)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
