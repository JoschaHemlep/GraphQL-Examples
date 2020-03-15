using HotChocolate.Types;

namespace GraphQL_Examples.Schema
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(_ => _.GetCustomer(default, default))
                .Argument("id", _ => _.Type<NonNullType<IntType>>())
                .Type<CustomerType>();

            descriptor.Field(_ => _.GetCustomers(default))
                .Type<NonNullType<ListType<CustomerType>>>();
        }
    }
}