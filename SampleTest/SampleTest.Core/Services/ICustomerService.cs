using SampleTest.Core.Models;
using SampleTest.Shared.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Core.Services
{
    public interface ICustomerService : IBaseService<Customer>
    {
    }
}
