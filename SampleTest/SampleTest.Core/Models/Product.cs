using SampleTest.Shared.Core.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Core.Models
{
    public class Product : BaseEntity<string>
    {        
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }

        public Product Create(Product product) 
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = product.Name;
            this.Qty = product.Qty;
            this.UnitPrice = product.UnitPrice;

            return this;
        }
        public Product Update(Product product)
        {
            this.Id = product.Id;
            this.Name = product.Name;
            this.Qty = product.Qty;
            this.UnitPrice = product.UnitPrice;

            return this;
        }
    }
}
