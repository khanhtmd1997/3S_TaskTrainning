using System.Collections.Generic;
using System.Threading.Tasks;
using TaskTranning.Models;
using TaskTranning.ViewModels;

namespace TaskTranning.Services.Interface
{
    public interface IStoreServices
    {
        Task<List<StoreViewModel>> GetListAsync();
        Task<bool> CreateStore(StoreViewModel storeView);
        Task<EditStoreViewModel> FindId(int? id);
        Task<bool> EditStore(EditStoreViewModel editStore);
        Task<bool> DeleteStore(int? id);
        IEnumerable<Store> GetStores();
    }
}