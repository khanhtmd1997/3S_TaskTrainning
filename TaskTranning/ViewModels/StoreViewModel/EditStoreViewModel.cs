using System.ComponentModel.DataAnnotations;

namespace TaskTranning.ViewModels
{
    public class EditStoreViewModel
    {
        public int Id { get; set; }

        public string StoreName { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
    }
}