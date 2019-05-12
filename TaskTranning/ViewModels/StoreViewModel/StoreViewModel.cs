using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TaskTranning.Models;

namespace TaskTranning.ViewModels
{
    public class StoreViewModel 
    {
        public int Id { get; set; }
        
        public string StoreName { get; set; }
        
        public int Phone { get; set; }
        
        public string Email { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
        
        public virtual ICollection<User> User { get; set; }
        
        public virtual ICollection<Stock> Stock { get; set; }
    }
}