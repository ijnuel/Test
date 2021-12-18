using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Coure_Assessment.Models;
using Coure_Assessment.ResponseModels;

namespace Coure_Assessment.Data.Mappings
{
    public class CountryMappings : Profile
    {
        public CountryMappings()
        {
            CreateMap<CountryDetails, CountryDetailsResponse>();
            CreateMap<Country, CountryResponse>()
                .ForMember(dest => dest.CountryDetails, opt => opt.MapFrom(src => src.CountryDetails));
        }
    }
}
