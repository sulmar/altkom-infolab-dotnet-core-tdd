﻿using System;
using System.Collections.Generic;
using TestApp.Mocking;

namespace TestApp.Fakers
{
    public interface ICustomerService
    {
        IEnumerable<Customer> Get();
        Customer Get(Guid id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(Guid id);
    }



    
}
