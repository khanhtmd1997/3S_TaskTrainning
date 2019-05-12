using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels;

namespace TaskTranning.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// registration UserServices, StoreServices,ResourcesServices
        /// </summary>
        private readonly IUserServices _userServices;

        private readonly IStoreServices _storeServices;

        private readonly ResourcesServices _resourcesServices;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userServices">declare userServices</param>
        public UserController(IUserServices userServices,IStoreServices storeServices,ResourcesServices resourcesServices)
        {
            _userServices = userServices;
            _storeServices = storeServices;
            _resourcesServices = resourcesServices;
        }
     
        /// <summary>
        /// 
        /// </summary>
        /// <returns>return login</returns>
        [HttpGet]
        public IActionResult LoginForm()
        {
            return View();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user">check login</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> LoginForm(LoginViewModel user)
        {       
            if (ModelState.IsValid)
            {    
                var isValidator = _userServices.Login(user.Email, user.PassWord);
                if (isValidator)
                {
                    var getEmail = await _userServices.GetEmail(user.Email);
                    HttpContext.Session.SetString("fullname",getEmail.FullName);
                    HttpContext.Session.SetString("picture",getEmail.Picture);
                    return RedirectToAction("Index","Home");
                }
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_ErrorLogin");
            return View(user);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>return index User</returns>
        [HttpGet]
        //public async Task<IActionResult> Index(string sortOrder,string search,int? page,string currentFilter
        public async Task<IActionResult> Index()
        {          
            var sessionEmail = HttpContext.Session.GetString("fullname");
            HttpContext.Session.GetString("picture");
            var listUsers = await _userServices.GetListAsync();
            ViewBag.Count = listUsers.Count;
            if (sessionEmail == null)
            {
                return RedirectToAction("LoginForm");
            }
//            ViewBag.EmailSort = String.IsNullOrEmpty(sortOrder) ? "email_desc" : "";
//            ViewBag.NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
//            var users = from s in listUser select s;
//            if (search != null)
//            {
//                page = 1;
//            }
//            else
//            {
//                search = currentFilter;
//            }
//            ViewBag.CurrentFilter = search;
//            if (!String.IsNullOrEmpty(search))
//            {
//                users = listUser.Where(s => s.Email.Contains(search) || s.FullName.Contains(search));
//            }
////            int pageSize = 10;
////            int pageNumber = (page ?? 1);
//            switch (sortOrder)
//            {
//                case "email_desc":
//                    users = users.OrderByDescending(s => s.Email);
//                    break;
//                case "name_desc":
//                    users = users.OrderByDescending(s => s.FullName);
//                    break;
//            }
            return View(listUsers.ToList());
//            return View(users.ToList());            
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>remove session for logout</returns>
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("fullname");
            return RedirectToAction("LoginForm");
        }

        // <summary>
        /// 
        /// </summary>
        /// <returns>go to Page Create User after check login</returns>
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            if (HttpContext.Session.GetString("fullname") == null) return RedirectToAction("LoginForm");
            ViewBag.StoreId = new SelectList(_storeServices.GetStores(),"Id","StoreName");
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="addUser">Create User</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(AddUserViewModel addUser)
        {
            HttpContext.Session.GetString("fullname");
            
            if (ModelState.IsValid)
            {
                if (await _userServices.CreateUser(addUser))
                {
                    ViewBag.StoreId = new SelectList(_storeServices.GetStores(),"Id","StoreName",addUser.StoreId);
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewUserSuccess").ToString();
                    return RedirectToAction("Index");  
                }                                            
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewUserError");
            ViewBag.StoreId = new SelectList(_storeServices.GetStores(),"Id","StoreName",addUser.StoreId);
            return View(addUser);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Check login before go to page Edit User</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("fullname") == null) return RedirectToAction("LoginForm");
            if (id == null)
            {
                return NotFound();
            }
            var findId = await _userServices.GetId(id);
            if (findId == null)
            {
                return NotFound();
            }
            ViewBag.StoreId = new SelectList(_storeServices.GetStores(),"Id","StoreName");
            return View(findId);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="editUser">Edit User</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel editUser)
        {
            HttpContext.Session.GetString("fullname");           
            if (ModelState.IsValid)
            {
                if (await _userServices.EditUser(editUser))
                {
                    ViewBag.StoreId = new SelectList(_storeServices.GetStores(), "Id", "StoreName", editUser.StoreId);
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditUserSuccess").ToString();
                    return RedirectToAction("Index");
                }
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditUserError");
            ViewBag.StoreId = new SelectList(_storeServices.GetStores(), "Id", "StoreName", editUser.StoreId);
            return View(editUser);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">get Id Image User</param>
        /// <returns></returns>
//        [HttpGet]
//        public async Task<IActionResult> EditUserImage(int? id)
//        {
//            var findId = await _userServices.GetIdUserImage(id);
//            if (findId == null)
//            {
//                return NotFound();
//            }
//            return View(findId);
//
//        }
//        
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="editImageUser">Edit Image User</param>
//        /// <returns></returns>
//        [HttpPost]
//        public async Task<IActionResult> EditUserImage(EditUserImageViewModel editImageUser)
//        {
//            if (ModelState.IsValid)
//            {
//                if (await _userServices.EditUserImage(editImageUser))
//                {
//                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("Edit Success").ToString();
//                    return RedirectToAction("Index");
//                } 
//            }
//            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("Edit Error");
//            return View(editImageUser);
//        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">get Id Password User</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> EditPassword(int? id)
        {
            
            if (HttpContext.Session.GetString("fullname") != null)
            {
                var findId = await _userServices.GetIdPassword(id);
                if (findId == null)
                {
                    return NotFound();
                }
                return PartialView("_ChangePassword",findId);
            }
            return RedirectToAction("LoginForm");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editPassword">Edit Password User</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> EditPassword(EditPasswordUserViewModel editPassword)
        {
            HttpContext.Session.GetString("fullname");
            if (ModelState.IsValid)
            {
                if (await _userServices.EditPassword(editPassword))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditUserPasswordSuccess").ToString();
                    return RedirectToAction("Index");
                }              
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditUserPasswordError");
            return PartialView("_ChangePassword",editPassword);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Delete User</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _userServices.DeleteUser(id))
            {
                TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteUserSuccess").ToString();
                return RedirectToAction("Index");
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteUserError");
            return View("Index");
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="culture"></param>
        /// <param name="returnUrl"></param>
        /// <returns>Setlanguage of Page</returns>
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(30) }
            );
            CultureInfo.CurrentCulture = CultureInfo.CurrentUICulture = new CultureInfo(culture);
            return LocalRedirect(returnUrl);
        } 

    }
}