using System;
using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Validation;
using FluentAssertions;
using Xunit;

namespace CleanArchMVC.Domain.Tests
{
    public class ProductTest
    {
        [Fact(DisplayName = "Create Product With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(
                1,
                "Product Name",
                "Product Description",
                9.99m,
                99,
                "Product Image"
            );

            action.Should()
                .NotThrow<DomainExceptValidation>();
        }
    }
}