using Microsoft.EntityFrameworkCore;
using SampleTest.Core.Models;
using SampleTest.Core.Repositories;
using SampleTest.Infrastructure.SampleTestContext;
using SampleTest.Shared.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly SampleTestDataContext context;

        public CustomerRepository(SampleTestDataContext context) 
        {
            this.context = context;
        }
        public async Task AddAsync(Customer entity)
        {
            await context.customers.AddAsync(entity);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            var customers = await context.customers.OrderBy(c => c.FirstName).ToListAsync();
            return customers;
        }

        public async Task<Customer> GetByIdAsync(string Id)
        {
            return await context.customers.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public void Remove(Customer entity)
        {
            context.Remove(entity);
        }

        public void Update(Customer entity)
        {
            context.customers.Update(entity);
        }
    }
}
