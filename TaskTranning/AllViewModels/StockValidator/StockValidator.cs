using FluentValidation;
using Microsoft.Extensions.Localization;
using TaskTranning.Resources;
using TaskTranning.ViewModels.StockViewModel;

namespace TaskTranning.AllViewModels.StockValidator
{
    public class StockValidator : AbstractValidator<StockViewModel>
    {
        public StockValidator(ResourcesServices _resourcesServices)
        {
            RuleFor(x => x.StoreId).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.ProductId).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Quantity).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
        }
    }
}