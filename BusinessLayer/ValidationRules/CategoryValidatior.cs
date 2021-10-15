using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior : AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Bırakmayınız.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklmasını Boş Bırakmayınız");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter giriniz");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En fazla 20 karakter girebilirsiniz");


        }
    }
}
