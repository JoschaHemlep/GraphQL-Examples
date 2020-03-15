using System;

namespace GraphQL_Examples.Models
{
    public class Item : ICloneable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ArticleNumber { get; set; }

        public object Clone() => new Item { Id = Id, Name = Name, ArticleNumber = ArticleNumber };
    }
}