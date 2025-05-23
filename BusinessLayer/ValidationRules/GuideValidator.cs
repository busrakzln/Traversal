﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklmasını giriniz. ");

            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber görseli giriniz.");

            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa isim giriniz.");

            RuleFor(x => x.Name).MinimumLength(8).WithMessage("Lütfen 8 karakterden daha uzun isim giriniz.");

        }
    }
}
