using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Core.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
