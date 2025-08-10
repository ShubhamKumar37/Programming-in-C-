using Bulky.DataAccess.Repository;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models.Models;
using Bulky.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _context;
        public ProductController(IUnitOfWork context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> ProductList = _context.Product.GetAll().ToList();
            
            return View(ProductList);
        }

        public IActionResult Upsert(int? id)
        {
            IEnumerable<SelectListItem> CategoryList = _context.Category.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            //ViewBag.CategoryList = CategoryList;
            if(id == null || id == 0)
            {
                // Create Product
                ProductVM productVM = new()
                {
                    Product = new Product(),
                    CategoryList = CategoryList
                };
                return View(productVM);
            }
            ProductVM obj = new()
            {
                Product = _context.Product.Get(u => u.Id == id),
                CategoryList = CategoryList
            };
            return View(obj);
        }

        [HttpPost]
        public IActionResult Upsert(ProductVM obj, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Add(obj.Product);
                _context.Save();
                TempData["success"] = "Product created successfully";
                return RedirectToAction("Index");
            }
            obj.CategoryList = _context.Category.GetAll()
            .Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            return View(obj);
        }

        //public IActionResult Edit(int? id)
        //{
        //    return View(_context.Product.Get(u => u.Id == id));
        //}

        //[HttpPost]
        //public IActionResult Edit(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Product.Update(product);
        //        _context.Save();
        //        TempData["success"] = "Product updated successfully";
        //        return RedirectToAction("Index");
        //    }
        //    return View(product);
        //}

        [HttpPost]
        [Route("Delete/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var productFromDb = _context.Product.Get(u => u.Id == id);
            if (productFromDb == null) return NotFound();

            _context.Product.Remove(productFromDb);
            _context.Save();
            TempData["success"] = "Product deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
