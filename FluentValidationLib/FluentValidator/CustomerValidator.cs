using FluentValidation;
using FluentValidationLib.Models;

namespace FluentValidationLib.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş bırakılamaz.";

        public CustomerValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("Lütfen geçerli bir email adresi giriniz.");
            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18,60).WithMessage("Yaşınız 18-60 aralığında olmalıdır.");
            RuleFor(x => x.BirthdayTime).Must(x => //custom validate
            {
                return DateTime.Now.AddYears(-18) >= x;
            }).WithMessage("18 yaşından büyük olmalısınız.");

            RuleFor(x => x.Gender).IsInEnum().WithMessage("{PropertyName} alanı Kadın için 1, Erkek için 2 olmalıdır.");

            RuleForEach(x => x.Addresses).SetValidator(new AddressValidator()); //one-many ilişkisinden dolayı
        }
    }
}
