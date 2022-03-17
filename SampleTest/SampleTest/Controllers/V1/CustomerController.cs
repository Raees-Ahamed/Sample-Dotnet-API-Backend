using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleTest.Core.Models;
using SampleTest.Core.Services;
using SampleTest.Dtos.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTest.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : BaseApiController
    {
        private readonly ICustomerService customerService;

        [HttpPost]
        public async Task<ActionResult> CreateCustomer(CustomerCreateDto customer)
        {
            var newCustomer = mapper.Map<Customer>(customer);
            await customerService.CreateAsync(newCustomer);
            return Ok();
        }
        public CustomerController(ICustomerService customerService, IMapper mapper) : base(mapper)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers() {
            var response = await customerService.GetAllAsync();
            return Ok(mapper.Map<IEnumerable<CustomerDto>>(response));
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Customer>> GetCustomers(string Id)
        {
            var response = await customerService.GetAsync(Id);            
            return Ok(mapper.Map<CustomerDto>(response));
        }       
    }
}
