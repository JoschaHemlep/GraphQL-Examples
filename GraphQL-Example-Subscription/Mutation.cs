using GraphQL_Examples.Models;
using HotChocolate;
using HotChocolate.Subscriptions;
using System.Threading.Tasks;

namespace GraphQL_Examples
{
    public class Mutation
    {
        public async Task<Customer> AddCustomer([Service]Store store, [Service]IEventSender eventSender, Customer customer)
        {
            store.AddCustomer(customer);

            await eventSender.SendAsync(new OnAddCustomerMessage(customer));

            return customer;
        }
    }
}