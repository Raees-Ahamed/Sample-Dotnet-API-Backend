﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Core.Repositories
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        Task <int> CommitAsync();
    }
}
