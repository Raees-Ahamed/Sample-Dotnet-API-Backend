using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleTest.Core.Models;
using SampleTest.Core.Services;
using SampleTest.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTest.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : BaseApiController
    {
        private readonly IProductService services;
        public ProductController(IProductService services, IMapper mapper) : base (mapper)
        {
            this.services = services;
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(CreateProductDto product) {
            var mappedProduct = mapper.Map<Product>(product);
            await services.CreateAsync(mappedProduct);
            return new JsonResult(new { message = "Product created successfully"}){ StatusCode = StatusCodes.Status200OK};
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProduct(UpdateProductDto product) {
            var mappedProduct = mapper.Map<Product>(product);
            await services.UpdateAsync(mappedProduct);
            return new JsonResult(new { message = "Product updated successfully" }) { StatusCode = StatusCodes.Status200OK };
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts() {
            var products =  await services.GetAllAsync();
            return Ok(mapper.Map<IEnumerable<ProductDto>>(products));
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(string Id) {
            var product = await services.GetAsync(Id);
            return Ok(mapper.Map<ProductDto>(product));
        }

    }
}
