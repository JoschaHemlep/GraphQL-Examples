using GraphQL_Examples.Models;
using HotChocolate.Types;

namespace GraphQL_Examples.Schema
{
    public class ItemType : ObjectType<Item>
    {
        protected override void Configure(IObjectTypeDescriptor<Item> descriptor)
        {
            descriptor.Field(_ => _.Id).Type<NonNullType<IntType>>();
            descriptor.Field(_ => _.Name).Type<NonNullType<StringType>>();
            descriptor.Field(_ => _.ArticleNumber).Type<NonNullType<StringType>>();
        }
    }
}