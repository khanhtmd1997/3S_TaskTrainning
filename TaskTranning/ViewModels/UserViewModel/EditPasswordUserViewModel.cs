using System.ComponentModel.DataAnnotations;

namespace TaskTranning.ViewModels
{
    public class EditPasswordUserViewModel
    {
        public EditPasswordUserViewModel(){}

        public EditPasswordUserViewModel(UserViewModel user)
        {
            Id = user.Id;
            PassWord = user.PassWord;
            NewPassword = user.NewPassword;
            ConfirmPassword = user.ConfirmPassword;

        }
        
        public int Id { get; set; }

        public string PassWord { get; set; }

        public string NewPassword { get; set; }

        public string ConfirmPassword { get; set; }
    }
}