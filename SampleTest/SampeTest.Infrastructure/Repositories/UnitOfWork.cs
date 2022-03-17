using SampleTest.Core.Repositories;
using SampleTest.Infrastructure.SampleTestContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SampleTestDataContext context;
        public ICustomerRepository _customerRepository;

        public UnitOfWork(SampleTestDataContext context)
        {
            this.context = context;
        }
        public ICustomerRepository CustomerRepository => _customerRepository ??= new CustomerRepository(context);

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
