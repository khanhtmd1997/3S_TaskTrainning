using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskTranning.Models;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels;

namespace TaskTranning.Services
{
    public class StoreServices : IStoreServices
    {
        private readonly CodeFirstDataContext _context;

        private readonly IMapper _mapper;

        public StoreServices(CodeFirstDataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Store> GetStores()
        {
            return _context.Store;
        }

        public async Task<List<StoreViewModel>> GetListAsync()
        {
            var stores = await _context.Store.ToListAsync();
            var storeViewModels = _mapper.Map<List<StoreViewModel>>(stores);
            return storeViewModels;
        }
        
        public async Task<bool> CreateStore(StoreViewModel storeView)
        {
            try
            {
                var store = new Store
                {
                    StoreName = storeView.StoreName,
                    Phone = storeView.Phone,
                    Email = storeView.Email,
                    Street = storeView.Street,
                    City = storeView.City,
                    State = storeView.State,
                    ZipCode = storeView.ZipCode
                };
                _context.Store.Add(store);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }

        public async Task<EditStoreViewModel> FindId(int? id)
        {
            var storeId = await _context.Store.FirstOrDefaultAsync(x => x.Id == id);
            var mapperStoreViewModel = _mapper.Map<EditStoreViewModel>(storeId);
            return mapperStoreViewModel;
        }

        public async Task<bool> EditStore(EditStoreViewModel editStore)
        {
            try
            {
                var storeId = await _context.Store.FirstOrDefaultAsync(x => x.Id == editStore.Id);
                storeId.Phone = editStore.Phone;
                storeId.StoreName = editStore.StoreName;
                storeId.Street = editStore.Street;
                storeId.City = editStore.City;
                storeId.State = editStore.State;
                storeId.ZipCode = editStore.ZipCode;
                _context.Store.Update(storeId);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }

        public async Task<bool> DeleteStore(int? id)
        {
            try
            {
                var storeId = await _context.Store.FindAsync(id);
                _context.Remove(storeId);
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