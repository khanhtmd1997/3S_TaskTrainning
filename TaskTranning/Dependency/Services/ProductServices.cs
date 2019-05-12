using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskTranning.Models;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.ProductViewModel;

namespace TaskTranning.Services
{
    public class ProductServices : IProductServices
    {
        private readonly CodeFirstDataContext _context;

        private readonly IMapper _mapper;
       
        public ProductServices(CodeFirstDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public IEnumerable<Product> GetProducts()
        {
            return _context.Product;
        } 
        
        public async Task<List<ProductViewModel>> GetListAsync()
        {
            var products = await _context.Product.Include(p => p.Brand).Include(p => p.Category).ToListAsync();
            var productViewModels = _mapper.Map<List<ProductViewModel>>(products);
            return productViewModels;
        }
        
        public async Task<bool> CreateProduct(ActionProductViewModel addProduct)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images",   addProduct.Picture.FileName);  
                using (var stream = new FileStream(path, FileMode.Create))  
                {  
                    await addProduct.Picture.CopyToAsync(stream);  
                }
                var product = new Product()
                {
                    ProductName = addProduct.ProductName,
                    BrandId = addProduct.BrandId,
                    CategoryId = addProduct.CategoryId,
                    ModelYear = addProduct.ModelYear,
                    ListPrice = addProduct.ListPrice,
                    Picture = addProduct.Picture.FileName
                };
                _context.Product.Add(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        
        public  async Task<ActionProductViewModel> FindId(int? id)
        {
            var productId = await _context.Product.FirstOrDefaultAsync(x => x.Id == id);
            var mapperUserViewModel =new ActionProductViewModel(productId);
            return mapperUserViewModel;
        }
        
        public async Task<bool> EditProduct(ActionProductViewModel editProduct)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images",   editProduct.Picture.FileName);  
                using (var stream = new FileStream(path, FileMode.Create))  
                {  
                    await editProduct.Picture.CopyToAsync(stream);  
                }
                var productId = await _context.Product.FirstOrDefaultAsync(x => x.Id == editProduct.Id);
                productId.ProductName = editProduct.ProductName;
                productId.BrandId = editProduct.BrandId;
                productId.ModelYear = editProduct.ModelYear;
                productId.ListPrice = editProduct.ListPrice;
                productId.Picture = editProduct.Picture.FileName;
                _context.Product.Update(productId);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        
//        public  async Task<EditProductImageViewModel> GetIdProductImage(int? Id)
//        {
//            var findId = await _context.Product.FirstOrDefaultAsync(x => x.Id == Id);
//            var getEditProductImageViewModel = new EditProductImageViewModel(findId);
//            return getEditProductImageViewModel;
//        }
//        
//        public async Task<bool> EditProductImage(EditProductImageViewModel editProductImage)
//        {
//            try
//            {
//                var product = await _context.Product.FirstOrDefaultAsync(x => x.Id == editProductImage.Id);
//                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images",   editProductImage.Picture.FileName);  
//                using (var stream = new FileStream(path, FileMode.Create))  
//                {  
//                    await editProductImage.Picture.CopyToAsync(stream);
//                }
//                product.Picture = editProductImage.Picture.FileName;
//                _context.Product.Update(product);
//                await _context.SaveChangesAsync();
//                return true;
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//                return false;
//            }
//            
//        }
        
        public async Task<bool> DeleteProduct(int? id)
        {
            try
            {
                var productId = await _context.Product.FindAsync(id);
                _context.Remove(productId);
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