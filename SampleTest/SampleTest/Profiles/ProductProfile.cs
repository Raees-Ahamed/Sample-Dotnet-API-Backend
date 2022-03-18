using AutoMapper;
using SampleTest.Core.Models;
using SampleTest.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTest.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductDto,Product>().ReverseMap();
            CreateMap<ProductDto,Product>().ReverseMap();
            CreateMap<UpdateProductDto,Product>().ReverseMap();
        }
    }
}
