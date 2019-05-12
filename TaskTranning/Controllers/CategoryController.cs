using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskTranning.AllViewModels.Category;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;

namespace TaskTranning.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _categoryServices;

        private readonly ResourcesServices _resourcesServices;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryServices">declare categoryServices</param>
        public CategoryController(ICategoryServices categoryServices,ResourcesServices resourcesServices)
        {
            _categoryServices = categoryServices;
            _resourcesServices = resourcesServices;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>return list Category</returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var session = HttpContext.Session.GetString("fullname");
            if (session == null) return RedirectToAction("LoginForm", "User");
            var listCategories = await _categoryServices.GetListAsync();
            if (listCategories == null)
            {
                return NotFound();
            }
            ViewBag.Count = listCategories.Count;
            return View(listCategories);
        }
        
        // <summary>
        /// 
        /// </summary>
        /// <returns>go to Page Create Category after check login</returns>
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
        /// <param name="addCategory">Create Category</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel addCategory)
        {
            HttpContext.Session.GetString("fullname");
            if (ModelState.IsValid)
            {
                if (await _categoryServices.CreateCategory(addCategory))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewCategorySuccess").ToString();
                    return RedirectToAction("Index");
                }              
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewCategoryError");
            return View(addCategory);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Check login before go to page Edit Category</param>
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
            var editCategory = await _categoryServices.FindId(id);
            if (editCategory == null)
            {
                return NotFound();
            }
            return View(editCategory);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="editCategory">Edit Category</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Edit(CategoryViewModel editCategory)
        {
            HttpContext.Session.GetString("fullname");
            if (ModelState.IsValid)
            {
                if (await _categoryServices.EditCategory(editCategory))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditCategorySuccess").ToString();
                    return RedirectToAction("Index");
                }
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditCategoryError");
            return View(editCategory);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Delete Category</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            HttpContext.Session.GetString("fullname");
            if (await _categoryServices.DeleteCategory(id))
            {
                TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteCategorySuccess").ToString();
                return RedirectToAction("Index");
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditCategoryError");
            return View("Index");

        }

    }
}