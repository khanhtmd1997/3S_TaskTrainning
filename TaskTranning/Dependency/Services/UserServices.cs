using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskTranning.Models;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels;


namespace TaskTranning.Services
{
//    public interface IUserServices
//    {
//        bool Login(string email, string password);
//        Task<UserViewModel> GetEmail(string email);
//        Task<List<UserViewModel>> GetListAsync();
//        Task<bool> CreateUser(AddUserViewModel userView);
//        Task<bool> EditUser(EditUserViewModel userEdit);
//        Task<bool> DeleteUser(int id);
//        Task<EditUserViewModel> GetIdUser(int? id);
//        Task<EditPasswordUserViewModel> GetIdPasswordUser(int? id);
//        Task<bool> EditPasswordUser(EditPasswordUserViewModel editPasswordUser);
//        IEnumerable<User> GetUsers();
//    }
    
    
    public class UserServices : IUserServices
    {
        private readonly CodeFirstDataContext _context;

        private readonly IMapper _mapper;
                  
        public UserServices(CodeFirstDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.User;
        }
        public bool Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || (string.IsNullOrEmpty(password)))
            {
                return false;
            }
            var user = _context.User.FirstOrDefault(x => x.Email == email && Infrastructure.SecurePasswordHasher.Verify(password,x.PassWord));

            if (user == null)
            {
                return false;
            }
            return true;
        }

        public async Task<UserViewModel> GetEmail(string email)
        {
            var findEmail = await _context.User.FirstOrDefaultAsync(x => x.Email == email);
            var getEmail = _mapper.Map<UserViewModel>(findEmail);
            return getEmail;
        }
        
        public async Task<List<UserViewModel>> GetListAsync()
        {
            var users = await _context.User.Include(u => u.Store).ToListAsync();
            var userViewModels = _mapper.Map<List<UserViewModel>>(users);
            return userViewModels;
        }
        
        public async Task<bool> CreateUser(AddUserViewModel userView)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images",   userView.Picture.FileName);  
                using (var stream = new FileStream(path, FileMode.Create))  
                {  
                    await userView.Picture.CopyToAsync(stream);  
                }
                var user = new User
                {
                    Email = userView.Email,
                    PassWord = Infrastructure.SecurePasswordHasher.Hash(userView.PassWord),
                    FullName = userView.FullName,
                    Phone = userView.Phone,
                    Picture = userView.Picture.FileName,
                    Address = userView.Address,
                    IsActive = userView.IsActive,
                    StoreId = userView.StoreId
                };
                _context.User.Add(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        } 

        public  async Task<EditUserViewModel> GetId(int? id)
        {
            var userId = await _context.User.FirstOrDefaultAsync(x => x.Id == id);
            var mapperUserViewModel =new EditUserViewModel(userId);
            return mapperUserViewModel;
        }
        public  async Task<EditPasswordUserViewModel> GetIdPassword(int? id)
        {
            var userId = await _context.User.FirstOrDefaultAsync(x => x.Id == id);
            var mapperPasswordUserViewModel = _mapper.Map<EditPasswordUserViewModel>(userId);
            return mapperPasswordUserViewModel;
        }

        public async Task<bool> EditUser(EditUserViewModel userEdit)
        {
            try
            {
                var userId = await _context.User.FirstOrDefaultAsync(x => x.Id == userEdit.Id);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images",   userEdit.Picture.FileName);  
                using (var stream = new FileStream(path, FileMode.Create))  
                {  
                    await userEdit.Picture.CopyToAsync(stream);  
                }
                userId.FullName = userEdit.FullName;
                userId.Phone = userEdit.Phone;
                userId.Picture = userEdit.Picture.FileName;
                userId.Address = userEdit.Address;
                userId.IsActive = userEdit.IsActive;
                userId.StoreId = userEdit.StoreId;
                _context.User.Update(userId);
                await _context.SaveChangesAsync();                        
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
        
        public async Task<bool> EditPassword(EditPasswordUserViewModel editPasswordUser)
        {
            try
            {
                var userId = await _context.User.FindAsync(editPasswordUser.Id);
                userId.PassWord = Infrastructure.SecurePasswordHasher.Hash(editPasswordUser.NewPassword);
                _context.User.Update(userId);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public async Task<bool> DeleteUser(int Id)
        {
            try
            {
                var userId = await _context.User.FindAsync(Id);
                _context.User.Remove(userId);
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