using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.UserMail).NotEmpty().WithMessage("Bir mail adresi girin");
            RuleFor(c => c.Subject).NotEmpty().WithMessage("Konu alanı boş bırakılamaz");
            RuleFor(c => c.UserName).NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz");
            RuleFor(c => c.Subject).MinimumLength(3).WithMessage("lütfen en az 3 karakter girişi yapın");
            RuleFor(c => c.UserName).MinimumLength(3).WithMessage("lütfen en az 3 karakter girişi yapın");
            RuleFor(c => c.Message).MaximumLength(50).WithMessage("lütfen 50 karakterden fazla giriş yapmayın");

        }
    }
}
