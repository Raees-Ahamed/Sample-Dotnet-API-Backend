using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTest.Dtos.Product
{
    public class CreateProductDto
    {     
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
