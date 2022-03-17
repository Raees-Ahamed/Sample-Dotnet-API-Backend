using SampleTest.Shared.Core.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Core.Models
{
    public class Customer : BaseEntity<string>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }

        public Customer Update(Customer customer) {
            Id = customer.Id;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Phone = customer.Phone;

            return this;
        }

        public Customer Create(Customer customer) {
            Id = Guid.NewGuid().ToString();
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Phone = customer.Phone;

            return this;
        }
    }
}
