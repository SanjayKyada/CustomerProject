using CustomerProject.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject.Application.Interfaces
{
    public interface ICustomerRepository

    {
        bool Add(Customer customer);
        Task<List<Customer>> GetAll();
    }
}
