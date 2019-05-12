﻿using System.ComponentModel.DataAnnotations;
using TaskTranning.Models;

namespace TaskTranning.ViewModels
{
    
    public class UserViewModel
    {   
        public int Id { get; set; }

        public string Email{ get; set; }

        public string PassWord { get; set; }

        public string NewPassword { get; set; }

        public string ConfirmPassword { get; set; }

        public string FullName { get; set; }

        public int Phone { get; set; }

        public string Address { get; set; }
 
        public string Picture { get; set; }

        public bool IsActive { get; set; }

        public int StoreId { get; set; }
        
        public virtual Store Store { get; set; }
    }
}