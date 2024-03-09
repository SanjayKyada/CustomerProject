using CustomerProject.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject.Infrastructure.StaticCustomer
{
    public static class CustomerCollections
    {
        public static List<Customer> customers = null;

        public static bool AddtoCollections(Customer customer)
        {
            try
            {
                if (customers == null) { customers = new List<Customer>(); }
                customers.Add(customer);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static async Task<List<Customer>> GetAllMembersFromCollections()
        {
            try
            {
                var customersList = (customers == null) ? new List<Customer>() : customers;
                return customersList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return customers;
            }

        }
    }
}
