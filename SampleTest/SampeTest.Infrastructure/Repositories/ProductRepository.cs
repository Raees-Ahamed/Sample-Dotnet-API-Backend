using Microsoft.EntityFrameworkCore;
using SampleTest.Core.Models;
using SampleTest.Core.Repositories;
using SampleTest.Infrastructure.SampleTestContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public readonly SampleTestDataContext context;

        public ProductRepository(SampleTestDataContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Product entity)
        {
            await context.products.AddAsync(entity);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await context.products.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(string Id)
        {
            return await context.products.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public void Remove(Product entity)
        {
            context.products.Remove(entity);
        }

        public void Update(Product entity)
        {
            context.products.Update(entity);
        }
    }
}
