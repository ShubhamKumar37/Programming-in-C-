using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class CreateModel(AppDbContext context) : PageModel
    {

        private readonly AppDbContext context = context;
        [BindProperty]
        public Category category { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            context.Categories.Add(category);
            context.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}
