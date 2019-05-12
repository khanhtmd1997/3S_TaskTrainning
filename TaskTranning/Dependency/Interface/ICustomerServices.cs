using System.Collections.Generic;
using System.Threading.Tasks;
using TaskTranning.Models;
using TaskTranning.ViewModels.CustomerViewModel;

namespace TaskTranning.Services.Interface
{
    public interface ICustomerServices
    {
        Task<List<CustomerViewModel>> GetListAsync();
        IEnumerable<Customer> GetCustomers();
        Task<bool> CreateCustomer(CustomerViewModel customers);
        Task<CustomerViewModel> FindId(int? id);
        Task<bool> EditCustomer(CustomerViewModel updateCustomer);
        Task<bool> DeleteCustomer(int? id);
    }
}