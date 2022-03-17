using Microsoft.EntityFrameworkCore;
using SampleTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Infrastructure.SampleTestContext
{
    public class SampleTestDataContext : DbContext
    {
        public SampleTestDataContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
