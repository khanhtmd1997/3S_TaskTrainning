﻿using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.ViewModels;

namespace TaskTranning.AllViewModels
{
    public abstract class UserValidator : AbstractValidator<UserViewModel>
    {
        protected UserValidator(ResourcesServices _resourcesServices)
        {
            RuleFor(x => x.Email).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Email).Length(1, 50).WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_toonefrommfifty"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_formatemail"));    
            RuleFor(x => x.PassWord).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.PassWord).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$").WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_letterandnumber"));
            RuleFor(x => x.PassWord).MaximumLength(100).WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_max100characters"));
            RuleFor(x => x.PassWord).MinimumLength(6).WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_min6characters"));
            RuleFor(x => x.FullName).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.FullName).Length(1,100).WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_toonefromonehundred"));
            RuleFor(x => x.Phone).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Picture).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.IsActive).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.Address).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
            RuleFor(x => x.StoreId).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_notnull"));
        }
    }
}