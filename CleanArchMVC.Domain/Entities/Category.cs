using System.Collections.Generic;
using CleanArchMVC.Domain.Validation;

namespace CleanArchMVC.Domain.Entities
{
    public sealed class Category: BaseEntity
    {
        public string Name { get; private set; }

        public Category(string name)
        {
           ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            ValidateDomain(name);
            Name = name;
            id = Id;
        }
        public ICollection<Product> Products { get; set; }

        public void Update(string name)
        {
            ValidateDomain(name);
        }

        private void ValidateDomain(string name)
        {
            DomainExceptValidation.When(
                string.IsNullOrEmpty(name),
                "Invalid name. Name is required"
            );

            DomainExceptValidation.When(
                name.Length < 3,
                "Invalid name, too short, minimun 3 characters"
            );

            Name = name;
        }
    }
}