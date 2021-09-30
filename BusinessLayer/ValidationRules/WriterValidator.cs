using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {

            RuleFor(c => c.WriterName).NotEmpty().WithMessage("yazar adı boş bırakılmaz...");
            RuleFor(c => c.WriterSurName).NotEmpty().WithMessage("yazarın soyadıalanı boş bırakılmaz");
            RuleFor(c => c.WriterAbout).NotEmpty().WithMessage("hakkımda boş bırakılmaz");
            RuleFor(c => c.WriterSurName).MinimumLength(3).WithMessage("en az 3 karakter girişi yapın");
            RuleFor(c => c.WriterSurName).MaximumLength(20).WithMessage("50 karakterden fazla olamaz");
           
        }
    }

 
}
