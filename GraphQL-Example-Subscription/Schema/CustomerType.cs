using GraphQL_Examples.Models;
using HotChocolate.Types;

namespace GraphQL_Examples.Schema
{
    public class CustomerType : ObjectType<Customer>
    {
        protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
        {
            descriptor.Field(_ => _.Id).Type<NonNullType<IntType>>();
            descriptor.Field(_ => _.Firstname).Type<NonNullType<StringType>>();
            descriptor.Field(_ => _.Lastname).Type<NonNullType<StringType>>();
            descriptor.Field(_ => _.Comment).Type<StringType>();
        }
    }
}