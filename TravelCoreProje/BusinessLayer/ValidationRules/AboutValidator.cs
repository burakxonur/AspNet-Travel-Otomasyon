using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmı Boş Bırakılamaz");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Bir Fotoğraf Seçiniz.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen 50 Karakter Açıklama Giriniz.");

        }
    }
}
