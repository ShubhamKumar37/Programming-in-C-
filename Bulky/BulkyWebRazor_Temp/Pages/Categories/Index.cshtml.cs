using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext context;
        public List<Category> Categories { get; set; } 

        public IndexModel(AppDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Categories = context.Categories.ToList();
        }

        
    }
}
