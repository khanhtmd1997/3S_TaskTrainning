using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.ViewModels;

namespace TaskTranning.AllViewModels.Store
{
    public class EditStoreValidator : AbstractValidator<EditStoreViewModel>
    {
        public EditStoreValidator(ResourcesServices _resourcesServices)
        {
            RuleFor(x => x.StoreName).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Phone).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Email).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_formatemail"));
            RuleFor(x => x.Street).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.City).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.ZipCode).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
        }
    }
}