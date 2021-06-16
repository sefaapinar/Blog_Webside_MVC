using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Kategori Adı Boş Geçilmez.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayınız.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazarın Hakkında Bölümünü Boş Geçemezsiniz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz.");

        }
        
    }
}
