using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL_Examples.Models
{
    public class Customer : ICloneable
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Comment { get; set; }

        public List<Item> PurchasedItems { get; set; } = new List<Item>();

        public object Clone() => new Customer
        {
            Id = Id,
            Firstname = Firstname,
            Lastname = Lastname,
            Comment = Comment,
            PurchasedItems = new List<Item>(PurchasedItems.Select(_ => (Item)_.Clone()))
        };
    }
}