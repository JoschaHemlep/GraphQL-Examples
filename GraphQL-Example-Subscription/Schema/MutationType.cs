using HotChocolate.Types;

namespace GraphQL_Examples.Schema
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Field(_ => _.AddCustomer(default, default, default))
                .Type<NonNullType<CustomerType>>()
                .Argument("customer", _ => _.Type<NonNullType<CustomerInputType>>());
        }
    }
}