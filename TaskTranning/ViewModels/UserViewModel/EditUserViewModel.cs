using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using TaskTranning.Models;

namespace TaskTranning.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel(){}
        public EditUserViewModel(User user)
        {
            Id = user.Id;
            Email = user.Email;
            FullName = user.FullName;
            Phone = user.Phone;
            Address = user.Address;
            IsActive = user.IsActive;
            StoreId = user.StoreId;

        }
        
        public int Id { get; set; }

        public string Email{ get; set; }       

        public string FullName { get; set; }

        public int Phone { get; set; }  

        public IFormFile Picture { get; set; }

        public string Address { get; set; }

        public bool IsActive { get; set; }

        public int StoreId { get; set; }
        
    }
}