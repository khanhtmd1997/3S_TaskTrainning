using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskTranning.AllViewModels.Category;
using TaskTranning.Models;
using TaskTranning.Services.Interface;

namespace TaskTranning.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly CodeFirstDataContext _context;

        private readonly IMapper _mapper;
        
        public CategoryServices(CodeFirstDataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Category;
        }
        
        public async Task<List<CategoryViewModel>> GetListAsync()
        {
            var categgories = await _context.Category.ToListAsync();
            var categoryViewModels = _mapper.Map<List<CategoryViewModel>>(categgories);
            return categoryViewModels;
        }

        public async Task<bool> CreateCategory(CategoryViewModel addCategory)
        {
            try
            {
                var category = new Category()
                {
                    CategoryName = addCategory.CategoryName
                };
                _context.Category.Add(category);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        
        public async Task<CategoryViewModel> FindId(int? id)
        {
            var categoryId = await _context.Category.FirstOrDefaultAsync(x => x.Id == id);
            var mapperCategoryViewModel = _mapper.Map<CategoryViewModel>(categoryId);
            return mapperCategoryViewModel;
        }

        public async Task<bool> EditCategory(CategoryViewModel editCategory)
        {
            try
            {
                var categoryId = await _context.Category.FirstOrDefaultAsync(x => x.Id == editCategory.Id);
                categoryId.CategoryName = editCategory.CategoryName;
                _context.Category.Update(categoryId);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        
        public async Task<bool> DeleteCategory(int? id)
        {
            try
            {
                var categoryId = await _context.Category.FindAsync(id);
                _context.Remove(categoryId);
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