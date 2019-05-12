using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.ViewModels;

namespace TaskTranning.AllViewModels
{
    public class EditUserValidator : AbstractValidator<EditUserViewModel>
    {
        public EditUserValidator(ResourcesServices _resourcesServices)
        {
            RuleFor(x => x.FullName).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.FullName).Length(1,100).WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_toonefromonehundred"));
            RuleFor(x => x.Phone).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.IsActive).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Address).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.StoreId).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Picture).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
        }

        
    }
}