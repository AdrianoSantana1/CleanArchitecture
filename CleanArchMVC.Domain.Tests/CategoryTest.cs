using System;
using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Validation;
using FluentAssertions;
using Xunit;

namespace CleanArchMVC.Domain.Tests
{
    public class CateogryTest
    {
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<DomainExceptValidation>();
        }

        [Fact(DisplayName = "Create Category Without name")]
        public void CreateCategory_WithoutName_ResultExceptValidation()
        {
            Action action = () => new Category(1, null);
            action.Should()
                .Throw<DomainExceptValidation>();
        }

        [Fact(DisplayName = "Create Category With name short")]
        public void CreateCategory_WithNameShort_ResultExceptValidation()
        {
            Action action = () => new Category(1, "ab");
            action.Should()
                .Throw<DomainExceptValidation>()
                .WithMessage("Invalid name, too short, minimun 3 characters");
        }

        [Fact(DisplayName = "Create Category With name Empty")]
        public void CreateCategory_WithNameEmpty_ResultExceptValidation()
        {
            Action action = () => new Category(1, "");
            action.Should()
                .Throw<DomainExceptValidation>();
        }
    }
}