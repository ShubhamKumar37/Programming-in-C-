using Microsoft.AspNetCore.Mvc;
using Bulky.DataAccess.Data;
using Bulky.Models.Models;
using Bulky.DataAccess.Repository.IRepository;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork context;

        public CategoryController(IUnitOfWork context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = context.Category.GetAll().ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View(); // If i do not pass anything the view will be created with a model with default values
        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound(); // If the id is null or 0, we return a NotFound result
            }

            var categoryFromDb = context.Category.Get(u => u.Id == id); // We find the category by id
            if (categoryFromDb == null) return NotFound(); // If the category is not found, we return NotFound

            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid) 
            {
                context.Category.Update(category);
                context.Save();
                TempData["success"] = "Category updated successfully"; // TempData is used to pass data between requests
                return RedirectToAction("Index");
            }
            return View(category); // If model state is not valid, we return the same view with the model to show validation errors
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if(category.Name == category.DisplayOrder.ToString()) ModelState.AddModelError("Name", "The DisplayOrder cannot exactly match the Name.");
            //if(category.Name != null && category.Name.ToLower() == "test") ModelState.AddModelError("Name", "Test is not allowed");
            if(ModelState.IsValid) // This validation is from data annotations in the model
            {
                context.Category.Add(category);
                context.Save();
                TempData["success"] = "Category created successfully"; // TempData is used to pass data between requests
                return RedirectToAction("Index"); // Index means the same controller, without it we can wrie the name of other controller where we wanted to redirect
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound(); // If the id is null or 0, we return a NotFound result

            var categoryFromDb = context.Category.Get(u => u.Id == id); // We find the category by id
            if (categoryFromDb == null) return NotFound(); // If the category is not found, we return NotFound

            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
                context.Category.Remove(category);
                context.Save();
                TempData["success"] = "Category deleted successfully"; // TempData is used to pass data between requests
            return RedirectToAction("Index");
        }
    }
}
