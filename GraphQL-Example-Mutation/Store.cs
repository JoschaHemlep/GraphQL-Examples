using GraphQL_Examples.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL_Examples
{
    public class Store
    {
        private readonly List<Customer> customers = new List<Customer>();

        public Customer GetCustomer(int id) => customers.FirstOrDefault(_ => _.Id == id);

        public List<Customer> GetCustomers() => new List<Customer>(customers.Select(_ => (Customer)_.Clone()));

        public void AddCustomer(Customer newCustomer) => customers.Add(newCustomer);
    }
}