using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels;

namespace TaskTranning.AllViewModels.Store
{
    public class StoreValidator : AbstractValidator<StoreViewModel>
    {
        public StoreValidator(ResourcesServices _resourcesServices,IStoreServices _storeServices)
        {
            var stores = _storeServices.GetStores();
            foreach (var store in stores)
            {
                RuleFor(x => x.Email).NotEqual(store.Email).WithMessage(_resourcesServices.GetLocalizedHtmlString("vld_alreadyexists"));
            }
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