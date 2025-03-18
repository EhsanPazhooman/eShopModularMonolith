namespace Catalog.Products.Models
{
    public class Product : Aggregate<Guid>
    {
        public string Name { get; private set; } = default!;
        public List<string> Category { get; private set; } = new();
        public string Description { get; private set; } = default!;
        public string ImageFile { get; private set; } = default!;
        public decimal Price { get; private set; }

        //Add a create method for initializing product entities
        public static Product Create(Guid id, string name, List<string> category, string description, string imageFile, decimal price)
        {
            Exceptions.ThrowIfNullOrEmpty(name, nameof(name));
            Exceptions.OutOfRangeException(price, nameof(price));

            var product = new Product
            {
                Id = id,
                Name = name,
                Category = category,
                Description = description,
                ImageFile = imageFile,
                Price = price
            };

            product.AddDomainEvent(new ProductCreatedEvent(product));   

            return product;

        }

        //Add an Update method for modifying Product entities
        public void Update(string name, List<string> category, string description, string imageFile, decimal price)
        {
            Exceptions.ThrowIfNullOrEmpty(name, nameof(name));
            Exceptions.OutOfRangeException(price, nameof(price));

            Name = name;
            Category = category;
            Description = description;
            ImageFile = imageFile;
            Price = price;

            //if price has changed , raise ProductPriceChanged domain event
            if (Price != price)
            {
                Price = price;
                AddDomainEvent(new ProductPriceChangedEvent(this));
            }


        }

    }
}
