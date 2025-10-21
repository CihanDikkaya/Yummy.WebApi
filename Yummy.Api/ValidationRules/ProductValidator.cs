using FluentValidation;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Yummy.Api.Entity;

namespace Yummy.Api.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adını boş geçmeyin.");
            RuleFor(p => p.Name).MinimumLength(2).WithMessage("En az 2 karakter girişi yapın!");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapın!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez!")
                .GreaterThan(0).WithMessage("Ürün fiyatı 0 dan aşağı olamaz!").LessThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz, girdiğiniz değeri kontrol edin!");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez!");
        }
    }
}
