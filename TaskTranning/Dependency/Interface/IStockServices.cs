using System.Collections.Generic;
using System.Threading.Tasks;
using TaskTranning.Models;
using TaskTranning.ViewModels.StockViewModel;

namespace TaskTranning.Services.Interface
{
    public interface IStockServices
    {
        IEnumerable<Stock> GetStocks();
        Task<List<StockViewModel>> GetListAsync();
        Task<bool> CreateStock(StockViewModel addStock);
        Task<StockViewModel> FindId(int? productId, int? storeId);
        Task<bool> EditStock(StockViewModel editStock);
        Task<bool> DeleteStock(int? productId, int? storeId);
    }
}