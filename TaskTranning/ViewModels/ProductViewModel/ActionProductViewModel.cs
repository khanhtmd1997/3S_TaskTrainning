using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using TaskTranning.Models;

namespace TaskTranning.ViewModels.ProductViewModel
{
    public class ActionProductViewModel
    {
        public ActionProductViewModel(){}

        public ActionProductViewModel(Product product)
        {
            Id = product.Id;
            ProductName = product.ProductName;
            BrandId = product.BrandId;
            CategoryId = product.CategoryId;
            ModelYear = product.ModelYear;
            ListPrice = product.ListPrice;
        }
        public int Id { get; set; }
        
        public string ProductName { get; set; }
        
        public int BrandId { get; set; }
        
        public int CategoryId { get; set; }
        
        public int ModelYear { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal ListPrice { get; set; }
        
        public IFormFile Picture { get; set; }
    }
}