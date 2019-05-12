using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskTranning.Models;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.CustomerViewModel;

namespace TaskTranning.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly CodeFirstDataContext _context;

        private readonly IMapper _mapper;

        public CustomerServices(CodeFirstDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customer;
        }
        public async Task<List<CustomerViewModel>> GetListAsync()
        {
            var customers = await _context.Customer.ToListAsync();
            var customerViewModels = _mapper.Map<List<CustomerViewModel>>(customers);
            return customerViewModels;
        }

        public async Task<bool> CreateCustomer(CustomerViewModel customers)
        {
            try
            {
                var customer = new Customer()
                {
                    FirstName = customers.FirstName,
                    LastName = customers.LastName,
                    Phone = customers.Phone,
                    Email = customers.Email,
                    Street = customers.Street,
                    City = customers.City,
                    State = customers.State,
                    ZipCode = customers.ZipCode
                };
                _context.Customer.Add(customer);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }

        public async Task<CustomerViewModel> FindId(int? id)
        {
            var customerId = await _context.Customer.FirstOrDefaultAsync(x=> x.Id == id);
            var mapperCustomerViewModel = _mapper.Map<CustomerViewModel>(customerId);
            return mapperCustomerViewModel;
        }

        public async Task<bool> EditCustomer(CustomerViewModel updateCustomer)
        {
            try
            {
                var customerId = await _context.Customer.FirstOrDefaultAsync(x => x.Id == updateCustomer.Id);
                customerId.FirstName = updateCustomer.FirstName;
                customerId.LastName = updateCustomer.LastName;
                customerId.Phone = updateCustomer.Phone;
                customerId.Email = updateCustomer.Email;
                customerId.Street = updateCustomer.Street;
                customerId.City = updateCustomer.City;
                customerId.State = updateCustomer.State;
                customerId.ZipCode = updateCustomer.ZipCode;
                _context.Customer.Update(customerId);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }

        public async Task<bool> DeleteCustomer(int? id)
        {
            try
            {
                var customerId = await _context.Customer.FindAsync(id);
                _context.Customer.Remove(customerId);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
      
    }
}