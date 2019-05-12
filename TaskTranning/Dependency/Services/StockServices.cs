using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskTranning.Models;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.StockViewModel;

namespace TaskTranning.Services
{
    public class StockServices : IStockServices
    {
        private readonly CodeFirstDataContext _context;

        private readonly IMapper _mapper;
        
        public StockServices(CodeFirstDataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Stock> GetStocks()
        {
            return _context.Stock;
        }
        public async Task<List<StockViewModel>> GetListAsync()
        {
            var stocks = await _context.Stock.Include(s => s.Product).Include(s => s.Store).ToListAsync();
            var stockViewModels = _mapper.Map<List<StockViewModel>>(stocks);
            return stockViewModels;
        }
        
        public async Task<bool> CreateStock(StockViewModel addStock)
        {
            try
            {
                var checkStock = await _context.Stock.FindAsync(addStock.ProductId , addStock.StoreId);
                if (checkStock != null)
                {
                    checkStock.Quantity += addStock.Quantity;
                    _context.Stock.Update(checkStock);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var stock = new Stock
                    {
                        ProductId = addStock.ProductId,
                        StoreId = addStock.StoreId,
                        Quantity = addStock.Quantity
                    };
                    _context.Stock.Add(stock);
                    await _context.SaveChangesAsync();
                }
            
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        
        public async Task<StockViewModel> FindId(int? productId, int? storeId)
        {
            var stockId = await _context.Stock.FirstOrDefaultAsync(x => x.ProductId == productId && x.StoreId == storeId);
            var mapperStockViewModel = _mapper.Map<StockViewModel>(stockId);
            return mapperStockViewModel;
        }
        
        public async Task<bool> EditStock(StockViewModel editStock)
        {
            try
            {
                var stockId = await _context.Stock.FirstOrDefaultAsync(x => x.ProductId == editStock.ProductId && x.StoreId == editStock.StoreId);
//            stock.ProductId = editStock.ProductId;
//            stock.StoreId = editStock.StoreId;
                stockId.Quantity = editStock.Quantity;
                _context.Stock.Update(stockId);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        
        public async Task<bool> DeleteStock(int? productId, int? storeId)
        {
            try
            {
                var stockId = await _context.Stock.FirstOrDefaultAsync(x => x.ProductId == productId && x.StoreId == storeId);
                _context.Remove(stockId);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
    }
    
}