using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        public Category category { get; set; }
        private readonly AppDbContext context;

        public DeleteModel(AppDbContext context)
        {
            this.context = context;
        }
        public void OnGet(int? id)
        {
            if(id == null || id == 0) category = new Category();
            else category = context.Categories.Find(id);
        }

        public IActionResult OnPost()
        {
            var obj = context.Categories.Find(category.Id);
            if (obj != null)
            {
                context.Categories.Remove(obj);
                context.SaveChanges();
                TempData["success"] = "Category deleted successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
