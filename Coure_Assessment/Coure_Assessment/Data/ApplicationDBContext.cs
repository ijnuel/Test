using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coure_Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Coure_Assessment.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<CountryDetails> CountryDetails { get; set; }
    }
}
