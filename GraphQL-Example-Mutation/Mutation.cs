using GraphQL_Examples.Models;
using HotChocolate;

namespace GraphQL_Examples
{
    public class Mutation
    {
        public Customer AddCustomer([Service]Store store, Customer customer)
        {
            store.AddCustomer(customer);

            return customer;
        }
    }
}