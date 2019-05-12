using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels;

namespace TaskTranning.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreServices _storeServices;
        
        private readonly ResourcesServices _resourcesServices;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="storeServices">declare storeServices</param>
        public StoreController(IStoreServices storeServices, ResourcesServices resourcesServices)
        {
            _storeServices = storeServices;
            _resourcesServices = resourcesServices;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>return list Store</returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var session = HttpContext.Session.GetString("fullname");
            if(session != null)
            {
                var listStores = await _storeServices.GetListAsync();
                if (listStores == null)
                {
                    return NotFound();
                }

                ViewBag.Count = listStores.Count;
                return View(listStores);
            }

            return RedirectToAction("LoginForm", "User");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>go to Page Create Store after check login</returns>
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
        /// <param name="addStore">Create Store</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(StoreViewModel addStore)
        {
            HttpContext.Session.GetString("fullname");
            if (ModelState.IsValid)
            {
                if (await _storeServices.CreateStore(addStore))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewStoreSuccess").ToString();
                    return RedirectToAction("Index");
                }    
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewStoreError");
            return View(addStore);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Check login before go to page Edit Store</param>
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
            var findId = await _storeServices.FindId(id);
            if (findId == null)
            {
                return NotFound();
            }
            return View(findId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editStore">Edit Store</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Edit(EditStoreViewModel editStore)
        {
            HttpContext.Session.GetString("fullname");
            if (ModelState.IsValid)
            {
                if (await _storeServices.EditStore(editStore))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditStoreSuccess").ToString();
                    return RedirectToAction("Index");
                } 
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditStoreError");
            return View(editStore);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Delete Store</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            HttpContext.Session.GetString("fullname");
            if (await _storeServices.DeleteStore(id))
            {
                TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteStoreSuccess").ToString();
                return RedirectToAction("Index");
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteStoreError");
            return View("Index");

        }
    }
}