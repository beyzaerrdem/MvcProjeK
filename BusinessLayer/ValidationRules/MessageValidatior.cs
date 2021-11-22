using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidatior : AbstractValidator<Message>
    {
        public MessageValidatior()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı mailini boş bırakmayınız.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Gönderen mailini boş bırakmayınız.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş geçmeyiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karakter giriniz");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("En fazla 100 karakter girebilirsiniz.");
        }
    }

   
}
