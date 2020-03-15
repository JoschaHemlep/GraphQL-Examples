using GraphQL_Examples.Models;
using HotChocolate.Subscriptions;

namespace GraphQL_Examples
{
    public class OnAddCustomerMessage : EventMessage
    {
        public OnAddCustomerMessage(Customer customer)
            : base(new EventDescription("onAddCustomer"), customer)
        {
        }
    }
}