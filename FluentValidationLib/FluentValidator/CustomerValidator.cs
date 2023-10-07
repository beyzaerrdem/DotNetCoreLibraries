using FluentValidation;
using FluentValidationLib.Models;

namespace FluentValidationLib.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş bırakılamaz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.").EmailAddress().WithMessage("Lütfen geçerli bir email adresi giriniz.");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Age alanı boş bırakılamaz.").InclusiveBetween(18,60).WithMessage("Yaşınız 18-60 aralığında olmalıdır.");
        }
    }
}
