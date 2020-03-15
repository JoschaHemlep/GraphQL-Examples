using GraphQL_Examples.Models;
using HotChocolate;
using System.Collections.Generic;

namespace GraphQL_Examples
{
    public class Query
    {
        public Customer GetCustomer([Service]Store store, int id) => store.GetCustomer(id);

        public List<Customer> GetCustomers([Service]Store store) => store.GetCustomers();
    }
}