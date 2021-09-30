
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(m => m.ReceiverMail).NotEmpty().WithMessage("Alıcı adresi boş bırakılamaz...");
            RuleFor(m => m.Subject).NotEmpty().WithMessage("Konu alanı boş bırakılamaz...");
            RuleFor(m => m.MessageContent).NotEmpty().WithMessage("Mesaj alanı boş bırakılamaz...");

        }
    }
}
