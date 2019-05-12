using System.Collections.Generic;
using System.Threading.Tasks;
using TaskTranning.Models;
using TaskTranning.ViewModels.BrandViewModel;

namespace TaskTranning.Services.Interface
{
    public interface IBrandServices
    {
        IEnumerable<Brand> GetBrands();
        Task<List<BrandViewModel>> GetListAsync();
        Task<bool> CreateBrand(BrandViewModel createBrand);
        Task<BrandViewModel> FindId(int? id);
        Task<bool> EditBrand(BrandViewModel editBrand);
        Task<bool> DeleteBrand(int? id);
    }
}