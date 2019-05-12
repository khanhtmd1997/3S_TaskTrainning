using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.BrandViewModel;

namespace TaskTranning.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandServices _brandServices;
        
        private readonly ResourcesServices _resourcesServices;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="brandServices">declare brandServices</param>
        public BrandController(IBrandServices brandServices, ResourcesServices resourcesServices)
        {
            _brandServices = brandServices;
            _resourcesServices = resourcesServices;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>return list Brands</returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var session = HttpContext.Session.GetString("fullname");
            if (session == null) return RedirectToAction("LoginForm", "User");
            var listBrands = await _brandServices.GetListAsync();
            if (listBrands == null)
            {
                return NotFound();
            }
            ViewBag.Count = listBrands.Count;
            return View(listBrands);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>go to Page Create Brand after check login</returns>
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var session = HttpContext.Session.GetString("fullname");
            if (session != null)
            {
                return View();
            }
            return RedirectToAction("LoginForm", "User");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="addBrand">Create Brand</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(BrandViewModel addBrand)
        {
            HttpContext.Session.GetString("fullname");
            if (ModelState.IsValid)
            {
                if (await _brandServices.CreateBrand(addBrand))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewCustomerSuccess").ToString();
                    return RedirectToAction("Index");
                }
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewCustomerError");
            return View(addBrand);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Check login before go to page Edit Brand</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var session = HttpContext.Session.GetString("fullname");
            if (session == null) return RedirectToAction("LoginForm", "User");
            if (id == null)
            {
                return NotFound();
            }
            var editBrand = await _brandServices.FindId(id);
            if (editBrand == null)
            {
                return NotFound();
            }
            return View(editBrand);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editBrand">Edit Brand</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Edit(BrandViewModel editBrand)
        {
            HttpContext.Session.GetString("fullname");
            if (ModelState.IsValid)
            {
                if (await _brandServices.EditBrand(editBrand))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditBrandSuccess").ToString();
                    return RedirectToAction("Index");
                }
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditBrandError");
            return View(editBrand);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Delete Brand</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            HttpContext.Session.GetString("fullname");
            if (await _brandServices.DeleteBrand(id))
            {
                TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteBrandSuccess").ToString();
                return RedirectToAction("Index");
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteBrandError");
            return View("Index");

        }
    }
}