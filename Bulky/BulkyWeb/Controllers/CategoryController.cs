using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWebRazor_Temp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext context;

        public CategoryController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();
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

            var categoryFromDb = context.Categories.Find(id); // We find the category by id
            if (categoryFromDb == null) return NotFound(); // If the category is not found, we return NotFound

            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid) 
            {
                context.Categories.Update(category);
                context.SaveChanges();
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
                context.Categories.Add(category);
                context.SaveChanges();
                TempData["success"] = "Category created successfully"; // TempData is used to pass data between requests
                return RedirectToAction("Index"); // Index means the same controller, without it we can wrie the name of other controller where we wanted to redirect
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound(); // If the id is null or 0, we return a NotFound result

            var categoryFromDb = context.Categories.Find(id); // We find the category by id
            if (categoryFromDb == null) return NotFound(); // If the category is not found, we return NotFound

            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
                context.Categories.Remove(category);
                context.SaveChanges();
                TempData["success"] = "Category deleted successfully"; // TempData is used to pass data between requests
            return RedirectToAction("Index");
        }
    }
}
