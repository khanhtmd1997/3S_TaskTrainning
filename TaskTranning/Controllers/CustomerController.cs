using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.CustomerViewModel;

namespace TaskTranning.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _customerServices;

        private readonly ResourcesServices _resourcesServices;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerServices">declare customerServices</param>
        public CustomerController(ICustomerServices customerServices, ResourcesServices resourcesServices)
        {
            _customerServices = customerServices;
            _resourcesServices = resourcesServices;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>return list Customer</returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var session = HttpContext.Session.GetString("fullname");
            if (session == null) return RedirectToAction("LoginForm", "User");
            var listCustomers = await _customerServices.GetListAsync();
            if (listCustomers == null)
            {
                return NotFound();
            }
            ViewBag.Count = listCustomers.Count;
            return View(listCustomers);
        }

        // <summary>
        /// 
        /// </summary>
        /// <returns>go to Page Create Customer after check login</returns>
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            if(HttpContext.Session.GetString("fullname" )!= null)
            {
                return View();
            }
            return RedirectToAction("LoginForm", "User");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="addCustomer">Create Customer</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CustomerViewModel addCustomer)
        {
            if (ModelState.IsValid)
            {
                if(await _customerServices.CreateCustomer(addCustomer))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewCustomerSuccess").ToString();
                    return RedirectToAction("Index");
                }      
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewCustomerError");
            return View(addCustomer);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Check login before go to page Edit Customer</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("fullname") == null) return RedirectToAction("LoginForm", "User");
            if (id == null)
            {
                return NotFound();
            }
            var getCustomerId = await _customerServices.FindId(id);
            return View(getCustomerId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editCustomer">Edit Customer</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Edit(CustomerViewModel editCustomer)
        {
            if (ModelState.IsValid)
            {
                if(await _customerServices.EditCustomer(editCustomer))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditCustomerSuccess").ToString();
                    return RedirectToAction("Index");
                }   
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditCustomerError");
            return View(editCustomer);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Delete Customer</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (await _customerServices.DeleteCustomer(id))
            {
                TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteCustomerSuccess").ToString();
                return RedirectToAction("Index");
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteCustomerError");
            return View("Index");
        }
    }
}