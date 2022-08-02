using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator: AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Details).NotEmpty().WithMessage("Açıklama boş geçiremez");
        }
    }
}