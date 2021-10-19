using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar ismini boş bırakmayınız.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş bırakmayınız.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında yazısını boş bırakmayınız.");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("En az 3 karakter giriniz.");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("En fazla 20 karakter girebilirsiniz.");
        }
     
        
    }
}
