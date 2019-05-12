using FluentValidation;
using TaskTranning.ViewModels;
using TaskTranning.Resources;

namespace TaskTranning.AllViewModels
{
    public class LoginVadidator : AbstractValidator<LoginViewModel>
    {
        public LoginVadidator(ResourcesServices _resourcesServices)
        {
            RuleFor(x => x.Email).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Email).Length(1, 50).WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_toonefrommfifty"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_formatemail"));
            RuleFor(x => x.PassWord).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.PassWord).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$").WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_letterandnumber"));
            RuleFor(x => x.PassWord).MaximumLength(100).WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_max100characters"));
            RuleFor(x => x.PassWord).MinimumLength(6).WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_min6characters"));
        }
        
    }
}