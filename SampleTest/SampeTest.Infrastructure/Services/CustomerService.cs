using SampleTest.Core.Models;
using SampleTest.Core.Repositories;
using SampleTest.Core.Services;
using SampleTest.Shared.Core.Common;
using SampleTest.Shared.Infrastructure.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleTest.Infrastructure.Services
{
    public class CustomerService :  ICustomerService
    {
        private readonly IUnitOfWork unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork) {
            this.unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Customer model)
        {
            await unitOfWork.CustomerRepository.AddAsync(model.Create(model));
            await unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(string Id)
        {
            var customer = await unitOfWork.CustomerRepository.GetByIdAsync(Id);
            if (customer == null) {
                throw new NotFoundException("Customer not found");
            }
            unitOfWork.CustomerRepository.Remove(customer);
            await unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            var customer = await unitOfWork.CustomerRepository.GetAllAsync();
            return customer;
        }

        public async Task<Customer> GetAsync(string Id)
        {
            var customer = await unitOfWork.CustomerRepository.GetByIdAsync(Id);
            return customer;
        }

        public async Task UpdateAsync(Customer model)
        {
            var customer = await unitOfWork.CustomerRepository.GetByIdAsync(model.Id);
            if (customer == null) {
                throw new NotFoundException("Customer not found");
            }
            unitOfWork.CustomerRepository.Update(customer.Update(model));
            await unitOfWork.CommitAsync();
        }
    }
}
