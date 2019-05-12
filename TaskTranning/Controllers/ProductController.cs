using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.ProductViewModel;
using ICategoryServices = TaskTranning.Services.Interface.ICategoryServices;
using IProductServices = TaskTranning.Services.Interface.IProductServices;

namespace TaskTranning.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;

        private readonly IBrandServices _brandServices;

        private readonly ICategoryServices _categoryServices;

        private readonly ResourcesServices _resourcesServices;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productServices">declare productServices</param>
        public ProductController(IProductServices productServices,IBrandServices brandServices,ICategoryServices categoryServices,ResourcesServices resourcesServices)
        {
            _productServices = productServices;
            _brandServices = brandServices;
            _categoryServices = categoryServices;
            _resourcesServices = resourcesServices;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>return list Product</returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var session = HttpContext.Session.GetString("fullname");
            if (session == null) return RedirectToAction("LoginForm", "User");
            var listProducts = await _productServices.GetListAsync();
            if (listProducts == null)
            {
                return NotFound();
            }
            ViewBag.Count = listProducts.Count;
            return View(listProducts);

        }
        
        // <summary>
        /// 
        /// </summary>
        /// <returns>go to Page Product after check login</returns>
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            if (HttpContext.Session.GetString("fullname") == null) return RedirectToAction("LoginForm", "User");
            ViewBag.BrandId = new SelectList(_brandServices.GetBrands(),"Id","BrandName");
            ViewBag.CategoryId = new SelectList(_categoryServices.GetCategories(),"Id","CategoryName");
            return View();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="addProduct">Create Product</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(ActionProductViewModel addProduct)
        {
            HttpContext.Session.GetString("fullname");
            
            if (ModelState.IsValid)
            {
                if (await _productServices.CreateProduct(addProduct))
                {
                    ViewBag.BrandId = new SelectList(_brandServices.GetBrands(), "Id", "BrandName", addProduct.BrandId);
                    ViewBag.CategoryId = new SelectList(_categoryServices.GetCategories(), "Id", "CategoryName",
                        addProduct.CategoryId);
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewProductSuccess").ToString();
                    return RedirectToAction("Index");
                }
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewProductSuccess");
            ViewBag.BrandId = new SelectList(_brandServices.GetBrands(), "Id", "BrandName", addProduct.BrandId);
            ViewBag.CategoryId = new SelectList(_categoryServices.GetCategories(), "Id", "CategoryName",
                addProduct.CategoryId);
            return View(addProduct);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Check login before go to page Edit Product</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("fullname") == null) return RedirectToAction("LoginForm", "User");
            if (id == null)
            {
                return NotFound();
            }
            var findId = await _productServices.FindId(id);
            if (findId == null)
            {
                return NotFound();
            }
            ViewBag.BrandId = new SelectList(_brandServices.GetBrands(),"Id","BrandName");
            ViewBag.CategoryId = new SelectList(_categoryServices.GetCategories(),"Id","CategoryName");
            return View(findId);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="editProduct">Edit Product</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Edit(ActionProductViewModel editProduct)
        {
            HttpContext.Session.GetString("fullname");           
            if (ModelState.IsValid)
            {
                if (await _productServices.EditProduct(editProduct))
                {
                    ViewBag.BrandId = new SelectList(_brandServices.GetBrands(), "Id", "BrandName", editProduct.BrandId);
                    ViewBag.CategoryId = new SelectList(_categoryServices.GetCategories(), "Id", "CategoryName",
                        editProduct.CategoryId);
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditProductSuccess").ToString();
                    return RedirectToAction("Index");
                }               
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditProductError");
            ViewBag.BrandId = new SelectList(_brandServices.GetBrands(), "Id", "BrandName", editProduct.BrandId);
            ViewBag.CategoryId = new SelectList(_categoryServices.GetCategories(), "Id", "CategoryName",
                editProduct.CategoryId);
            return View(editProduct);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">get Id Edit Image Product</param>
        /// <returns></returns>
//        [HttpGet]
//        public async Task<IActionResult> EditProductImage(int? id)
//        {
//
//            var findId = await _productServices.GetIdProductImage(id);
//            if (findId == null)
//            {
//                return NotFound();
//            }
//            return View(findId);
//        }
//        
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="id">Edit Image Product</param>
//        /// <returns></returns>
//        [HttpPost]
//        public async Task<IActionResult> EditProductImage(EditProductImageViewModel editImageProduct)
//        {
//            if (ModelState.IsValid)
//            {
//                if (await _productServices.EditProductImage(editImageProduct))
//                {
//                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("Edit Success").ToString();
//                    return RedirectToAction("Index");
//                }              
//            }
//            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("Edit Error");
//            return View(editImageProduct);
//        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Delete Product</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (await _productServices.DeleteProduct(id))
            {
                TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteProductSuccess").ToString();
                return RedirectToAction("Index");
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteProductError");
            return View("Index");
        }

    }
}