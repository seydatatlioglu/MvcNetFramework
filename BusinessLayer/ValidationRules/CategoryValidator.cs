using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c=>c.CategoryName).NotEmpty().WithMessage("kategori adı boş bırakılmaz...");
            RuleFor(c=>c.CategoryDescription).NotEmpty().WithMessage("açıklama alanı boş bırakılmaz");
            RuleFor(c=>c.CategoryName).MinimumLength(3).WithMessage("en az 3 karakter girişi yapın");
            RuleFor(c=>c.CategoryName).MaximumLength(20).WithMessage("20 karakterden fazla olamaz");
            RuleFor(c=>c.CategoryDescription).MaximumLength(20).WithMessage("20 karakterden fazla olamaz");
        }
    }
}
