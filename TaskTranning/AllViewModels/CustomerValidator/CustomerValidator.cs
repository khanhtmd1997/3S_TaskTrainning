using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.ViewModels.CustomerViewModel;

namespace TaskTranning.AllViewModels.Customer
{
    public class CustomerValidator : AbstractValidator<CustomerViewModel>
    {
        public CustomerValidator(ResourcesServices _resourcesServices)
        {
            RuleFor(x => x.Email).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_formatemail"));
            RuleFor(x => x.FirstName).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.LastName).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Phone).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Street).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.City).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.ZipCode).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
        }
    }
}