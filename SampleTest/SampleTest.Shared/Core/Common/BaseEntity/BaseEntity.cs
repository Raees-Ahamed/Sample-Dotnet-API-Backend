using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Shared.Core.Common.BaseEntity
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
