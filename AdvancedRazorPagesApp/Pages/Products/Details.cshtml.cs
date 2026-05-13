using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesAdvancedApp.Models;
using System.Linq;

namespace RazorPagesAdvancedApp.Pages.Products
{
    public class DetailsModel : PageModel
    {
        public Product Product { get; set; } = new Product();

        public IActionResult OnGet(int id)
        {
            Product = IndexModel.ProductsStorage
    .FirstOrDefault(p => p.ProductID == id) ?? new Product();

            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}