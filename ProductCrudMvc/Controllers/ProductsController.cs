using Microsoft.AspNetCore.Mvc;
using ProductCrudMvc.Models;
using ProductCrudMvc.Services;

namespace ProductCrudMvc.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService productService;//Dependency Injection
        

        //Constructor
        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllProduct()
        {
          List<Product> product=productService.getAllProducts();
            return Json(product);

        }
        [HttpGet]
        public IActionResult FindById()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FindById(int id )
        {
            Product product=productService.GetProductById(id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return Json(product);

        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(string title, string description, double unitePrice, string imageUrl, string quantity)
        {
            
 
            int quan=int.Parse(quantity);

            Product product=new Product(title , description, unitePrice, imageUrl ,quan);

            productService.AddProduct(product);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            productService.DeleteProduct(id);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(string id, string title, string description,double unitePrice,string imageUrl,string quantity)
        {   
            
            int pid = int.Parse(id);
            int quant=int.Parse(quantity);

            Product product=new Product(pid,title, description,unitePrice, imageUrl ,quant);
            productService.UpdateProduct(product);
            return RedirectToAction("index");
        }

        
       
    }
}
