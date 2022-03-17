using SampleTest.Core.Models;
using SampleTest.Shared.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Core.Repositories
{
    public interface ICustomerRepository : IRepository<Customer> { }
}
