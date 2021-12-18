using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Coure_Assessment.Data;
using Coure_Assessment.Models;
using Coure_Assessment.Implementations;
using Coure_Assessment.Abstractions;
using AutoMapper;
using Coure_Assessment.ResponseModels;

namespace Coure_Assessment.Controllers
{
    [Route("api")]
    [ApiController]
    public class NumberDetailsController : ControllerBase
    {
        private readonly IServices _services;

        public NumberDetailsController(IServices services)
        {
            _services = services;
        }

        [HttpGet("solve-array")]
        public IActionResult SolveArray([FromBody] List<int> numbers)
        {
            int output = 0;
            foreach (int number in numbers)
            {
                if (number == 8)
                {
                    output += 5;
                }
                if (number % 2 == 0)
                {
                    output += 1;
                }
                else
                {
                    output += 3;
                }
            }
            return Ok(output);
        }

        // GET: api/NumberDetails/2348033432323
        [HttpGet("{phoneNumber}")]
        public IActionResult GetCountryDetails(string phoneNumber)
        {
            if (_services.VerifyPhoneNumber(phoneNumber))
            {
                string countryCode = phoneNumber.Substring(0, 3);
                var countryDetails = _services.Country.GetCountryDetails(countryCode);
                if (countryDetails != null)
                {
                    var numberCountryDetails = new NumberCountryDetails
                    {
                        Number = phoneNumber,
                        Country = _services.Mapper.Map<CountryResponse>(countryDetails)
                    };
                    return new JsonResult(numberCountryDetails);
                }
                return Ok(new { number = phoneNumber, country = "Not Found" });
            }
            return BadRequest(new { error = "Invalid Phone Number" });
        }
    }
}
