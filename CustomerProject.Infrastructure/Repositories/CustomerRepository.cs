using CustomerProject.Application.Interfaces;
using CustomerProject.Domain.Customer;
using CustomerProject.Infrastructure.StaticCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool Add(Customer customer)
        {
            return CustomerCollections.AddtoCollections(customer);
        }

        public async Task<List<Customer>> GetAll()
        {
            return await CustomerCollections.GetAllMembersFromCollections();
        }
    }
}
