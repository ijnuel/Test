using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Coure_Assessment.Abstractions.Repositories;

namespace Coure_Assessment.Abstractions
{
    public interface IServices : IDisposable
    {
        ICountryRepo Country { get; }

        IMapper Mapper { get; set; }
        bool VerifyPhoneNumber(string phoneNumber);
    }
}
