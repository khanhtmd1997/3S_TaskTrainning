using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace TaskTranning.ViewModels
{
    public class AddUserViewModel
    {

        public string Email{ get; set; }

        public string PassWord { get; set; }

        public string FullName { get; set; }

        public int Phone { get; set; }

        public string Address { get; set; }

        public IFormFile Picture { get; set; }

        public bool IsActive { get; set; }

        public int StoreId { get; set; }
        
    }
}