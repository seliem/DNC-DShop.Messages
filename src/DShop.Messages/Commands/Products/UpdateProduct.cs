using Newtonsoft.Json;
using System;

namespace DShop.Messages.Commands.Products
{
	public class UpdateProduct : ICommand
	{
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }

        [JsonConstructor]
        private UpdateProduct(Guid? id, string name, string description, string vendor, decimal price)
        {
            Id = id ?? Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
        }
    }
}