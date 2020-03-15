using HotChocolate.Types;

namespace GraphQL_Examples.Schema
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Field(t => t.AddCustomer(default, default))
                .Type<NonNullType<CustomerType>>()
                .Argument("customer", a => a.Type<NonNullType<CustomerInputType>>());
        }
    }
}