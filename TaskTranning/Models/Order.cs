using System;
using System.ComponentModel.DataAnnotations;

namespace TaskTranning.Models
{
    public class Order
    {

        public int Id { get; set; }
        
        public int CustomerId { get; set; }
        
        public int OrderStatus { get; set; }
        
        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public int StoreId { get; set; }

        public int UserId { get; set; }
        
        public virtual Customer Customer { get; set; }

    }
}