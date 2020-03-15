using HotChocolate.Types;

namespace GraphQL_Examples.Schema
{
    public class SubscriptionType : ObjectType<Subscription>
    {
        protected override void Configure(IObjectTypeDescriptor<Subscription> descriptor)
        {
            descriptor.Field(_ => _.OnAddCustomer(default))
                .Type<NonNullType<CustomerType>>();
        }
    }
}