using System.ComponentModel.DataAnnotations;
using TaskTranning.Models;

namespace TaskTranning.ViewModels.StockViewModel
{
    public class StockViewModel
    {       
        public int StoreId { get; set; }
        
        public int ProductId { get; set; }
        
        public int Quantity { get; set; }
        
        public virtual Product Product { get; set; }
        
        public virtual Store Store { get; set; }

    }
}