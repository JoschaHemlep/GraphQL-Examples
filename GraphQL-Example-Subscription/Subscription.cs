using GraphQL_Examples.Models;
using HotChocolate.Subscriptions;

namespace GraphQL_Examples
{
    public class Subscription
    {
        public Customer OnAddCustomer(IEventMessage message) => (Customer)message.Payload;
    }
}