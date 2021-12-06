using System;

namespace CleanArchMVC.Domain.Validation
{
    public class DomainExceptValidation: Exception
    {
        public DomainExceptValidation(string error): base(error){}

        public static void When(bool hasError, string errorMessage)
        {
            if (hasError)
                throw new DomainExceptValidation(errorMessage);
        }
    }
}