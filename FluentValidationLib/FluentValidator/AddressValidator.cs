using FluentValidation;
using FluentValidationLib.Models;

namespace FluentValidationLib.FluentValidator
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş bırakılamaz.";

        public AddressValidator() 
        { 
            RuleFor(x => x.Content).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.Province).NotEmpty().WithMessage(NotEmptyMessage).MaximumLength(10).WithMessage("{PropertyName} alanı en fazla {MaxLength} karakterden oluşabilir.");            
        }
    }
}
