using MVC_Introduction.Models;
using MVC_Introduction.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC_Introduction.Controllers
{
    public class ProductController : Controller
    {

        private IProductService _service;

        public ProductController(IProductService productService)
        { 
            _service = productService;
        }
        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            IList<GetProductsViewModel> products = _service.GetProducts();
            return View(products);
        }
        
        public ActionResult Edit(long id)
        {
            var product = _service.EditProduct(id);
            return View(product);
;       }

        [HttpPost]
        public ActionResult Edit(long id, EditProductViewModel editProductViewModel)
        {
            _service.SaveProduct(editProductViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateProductViewModel createProductViewModel)
        {
            _service.CreateProduct(createProductViewModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(long id)
        {
            _service.FindProduct(id);
            return View();
        }    
        
        [HttpPost]
        public ActionResult Delete(GetProductsViewModel getProductsViewModel)
        {
            _service.DeleteProduct(getProductsViewModel);
            return RedirectToAction("Index");
        }

        [ValidateAntiForgeryToken]
        public string GetResult(string input)
        {
            return string.Empty;
        }

    }
}