using CleanArchMVC.Domain.Validation;

namespace CleanArchMVC.Domain.Entities
{
    public sealed class Product: BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

        public Product(
            int id,
            string name, 
            string description, 
            decimal price, 
            int stock, 
            string image
        )
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }
        
        private void Update(
            string name,
            string description, 
            decimal price, 
            int stock, 
            string image,
            int categoryId
        )
        {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categoryId;
        }

        private void ValidateDomain(
            string name,
            string description,
            decimal price,
            int stock,
            string image
        )
        {
            DomainExceptValidation.When(
                string.IsNullOrEmpty(name),
                "Invalid name. Name is Required"
            );

            DomainExceptValidation.When(
                name.Length < 3,
                "Invalid name. Name is too short"
            );

            DomainExceptValidation.When(
                string.IsNullOrEmpty(description),
                "Invalid description. description is Required"
            );

            DomainExceptValidation.When(
                description.Length < 3,
                "Invalid description. description is too short"
            );

            DomainExceptValidation.When(
                price < 0,
                "Invalid price value"
            );

            DomainExceptValidation.When(
                stock < 0,
                "Invalid stock value"
            );

            DomainExceptValidation.When(
                image.Length > 250,
                "Invalid image name url"
            );

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }
    }
}