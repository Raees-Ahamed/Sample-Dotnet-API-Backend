using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTest.Controllers
{
    
    public class BaseApiController : ControllerBase
    {
        public readonly IMapper mapper;

        public BaseApiController(IMapper mapper)
        {
            this.mapper = mapper;
        }
    }
}
