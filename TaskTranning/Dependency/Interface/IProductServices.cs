using System.Collections.Generic;
using System.Threading.Tasks;
using TaskTranning.Models;
using TaskTranning.ViewModels.ProductViewModel;

namespace TaskTranning.Services.Interface
{
    public interface IProductServices
    {
        IEnumerable<Product> GetProducts();
        Task<List<ProductViewModel>> GetListAsync();
        Task<bool> CreateProduct(ActionProductViewModel addProduct);
        Task<ActionProductViewModel> FindId(int? id);
        Task<bool> EditProduct(ActionProductViewModel editProduct);
        Task<bool> DeleteProduct(int? id);
    }
}