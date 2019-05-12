using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskTranning.Models;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.BrandViewModel;

namespace TaskTranning.Services
{
    public class BrandServices : IBrandServices
    {
        private readonly CodeFirstDataContext _context;

        private readonly IMapper _mapper;
        
        public BrandServices(CodeFirstDataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brand;
        }
        
        public async Task<List<BrandViewModel>> GetListAsync()
        {
            var stores = await _context.Brand.ToListAsync();
            var brandViewModels = _mapper.Map<List<BrandViewModel>>(stores);
            return brandViewModels;
        }
        
        public async Task<bool> CreateBrand(BrandViewModel createBrand)
        {
            try
            {
                var brand = new Brand
                {
                    BrandName = createBrand.BrandName        
                };
                _context.Brand.Add(brand);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
           
        }
        
        public async Task<BrandViewModel> FindId(int? id)
        {
            var brandId = await _context.Brand.FirstOrDefaultAsync(x => x.Id == id);
            var mapperBrandViewModel = _mapper.Map<BrandViewModel>(brandId);
            return mapperBrandViewModel;
        }
        
        public async Task<bool> EditBrand(BrandViewModel editBrand)
        {
            try
            {
                var brandId = await _context.Brand.FirstOrDefaultAsync(x => x.Id == editBrand.Id);
                brandId.BrandName = editBrand.BrandName;
                _context.Brand.Update(brandId);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        
        public async Task<bool> DeleteBrand(int? id)
        {
            try
            {
                var brandId = await _context.Brand.FindAsync(id);
                _context.Remove(brandId);
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