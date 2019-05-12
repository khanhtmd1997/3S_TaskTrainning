using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.StockViewModel;
using IProductServices = TaskTranning.Services.Interface.IProductServices;
using IStockServices = TaskTranning.Services.Interface.IStockServices;

namespace TaskTranning.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockServices _stockServices;
        
        private readonly IProductServices _productServices;
        
        private readonly IStoreServices _storeServices;

        private readonly ResourcesServices _resourcesServices;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stockServices">declare stockServices</param>
        public StockController(IStockServices stockServices, IProductServices productServices, IStoreServices storeServices,ResourcesServices resourcesServices)
        {
            _stockServices = stockServices;
            _productServices = productServices;
            _storeServices = storeServices;
            _resourcesServices = resourcesServices;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>return list Stock</returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var session = HttpContext.Session.GetString("fullname");
            if(session != null)
            {
                var listStocks = await _stockServices.GetListAsync();
                if (listStocks == null)
                {
                    return NotFound();
                }
                ViewBag.Count = listStocks.Count;
                return View(listStocks);
            }
            return RedirectToAction("LoginForm", "User");
        }
        
        // <summary>
        /// 
        /// </summary>
        /// <returns>go to Page Stock after check login</returns>
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var session = HttpContext.Session.GetString("fullname");
            if (session == null) return RedirectToAction("LoginForm", "User");
            ViewBag.ProductId = new SelectList(_productServices.GetProducts(),"Id","ProductName");
            ViewBag.StoreId = new SelectList(_storeServices.GetStores(),"Id","StoreName");
            return View();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="addStock">Create Stock</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(StockViewModel addStock)
        {
            HttpContext.Session.GetString("fullname");
            if (ModelState.IsValid)
            {
                if (await _stockServices.CreateStock(addStock))
                {
                    ViewBag.ProductId = new SelectList(_productServices.GetProducts(),"Id","ProductName",addStock.ProductId);
                    ViewBag.StoreId = new SelectList(_storeServices.GetStores(),"Id","StoreName",addStock.StoreId);
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewStockSuccess").ToString();
                    return RedirectToAction("Index");
                }              
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewStockError");
            ViewBag.ProductId = new SelectList(_productServices.GetProducts(),"Id","ProductName",addStock.ProductId);
            ViewBag.StoreId = new SelectList(_storeServices.GetStores(),"Id","StoreName",addStock.StoreId);
            return View(addStock);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Check login before go to page Edit Stock</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int? productId,int? storeId)
        {
            var session = HttpContext.Session.GetString("fullname");
            if (session == null) return RedirectToAction("LoginForm", "User");
            if (productId == null || storeId == null)
            {
                return NotFound();
            }
            var findId = await _stockServices.FindId(productId,storeId);
            ViewBag.ProductId = new SelectList(_productServices.GetProducts(),"Id","ProductName");
            ViewBag.StoreId = new SelectList(_storeServices.GetStores(),"Id","StoreName");
            if (findId == null)
            {
                return NotFound();
            }
            return View(findId);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="editStock">Edit Stock</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Edit(StockViewModel editStock)
        {
            HttpContext.Session.GetString("fullname");
            if (ModelState.IsValid)
            {
                if (await _stockServices.EditStock(editStock))
                {
                    ViewBag.ProductId = new SelectList(_productServices.GetProducts(),"Id","ProductName",editStock.ProductId);
                    ViewBag.StoreId = new SelectList(_storeServices.GetStores(),"Id","StoreName",editStock.StoreId);
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditStockSuccess").ToString();
                    return RedirectToAction("Index");
                }
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditStockError");
            ViewBag.ProductId = new SelectList(_productServices.GetProducts(),"Id","ProductName",editStock.ProductId);
            ViewBag.StoreId = new SelectList(_storeServices.GetStores(),"Id","StoreName",editStock.StoreId);
            return View(editStock);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Delete Stock</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Delete(int? productId,int? storeId)
        {
            HttpContext.Session.GetString("fullname");
            if (await _stockServices.DeleteStock(productId,storeId))
            {
                TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteStockSuccess").ToString();
                return RedirectToAction("Index");
            }
            ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteStockError");
            return View("Index");

        }
    }
}