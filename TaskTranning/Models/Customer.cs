using System.Collections.Generic;

namespace TaskTranning.Models
{
    public class Customer
    {

        public int Id { get; set; }
        

        public string FirstName { get; set; }
        

        public string LastName { get; set; }
        

        public int Phone { get; set; }
        

        public string Email { get; set; }
        

        public string Street { get; set; }
        

        public string City { get; set; }
        

        public string State { get; set; }
        

        public string ZipCode { get; set; }
        
        public virtual ICollection<Order> Order { get; set; }
    }
}