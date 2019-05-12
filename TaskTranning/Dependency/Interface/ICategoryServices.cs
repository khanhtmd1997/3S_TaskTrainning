using System.Collections.Generic;
using System.Threading.Tasks;
using TaskTranning.AllViewModels.Category;
using TaskTranning.Models;

namespace TaskTranning.Services.Interface
{
    public interface ICategoryServices
    {
        IEnumerable<Category> GetCategories();
        Task<List<CategoryViewModel>> GetListAsync();
        Task<bool> CreateCategory(CategoryViewModel addCategory);
        Task<CategoryViewModel> FindId(int? id);
        Task<bool> EditCategory(CategoryViewModel editCategory);
        Task<bool> DeleteCategory(int? id);
    }
}