using SampleTest.Core.Models;
using SampleTest.Core.Repositories;
using SampleTest.Core.Services;
using SampleTest.Shared.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(Product model)
        {
            await unitOfWork.ProductRepository.AddAsync(model.Create(model));
            await unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(string Id)
        {
            var product = await unitOfWork.ProductRepository.GetByIdAsync(Id);
            if (product == null) {
                throw new NotFoundException("Product not found");
            }
            unitOfWork.ProductRepository.Remove(product);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await unitOfWork.ProductRepository.GetAllAsync();
        }

        public async Task<Product> GetAsync(string Id)
        {
            return await unitOfWork.ProductRepository.GetByIdAsync(Id);
        }

        public async Task UpdateAsync(Product model)
        {
            var product = await unitOfWork.ProductRepository.GetByIdAsync(model.Id);
            if (product == null) {
                throw new NotFoundException("Product not found");
            }
            unitOfWork.ProductRepository.Update(product.Update(model));
            await unitOfWork.CommitAsync();
        }
    }
}
