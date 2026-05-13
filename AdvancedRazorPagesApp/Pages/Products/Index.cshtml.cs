using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesAdvancedApp.Models;

namespace RazorPagesAdvancedApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Product NewProduct { get; set; } = new Product
        {
            Categories = new List<Category>
            {
                new Category(),
                new Category()
            }
        };

        public List<Product> ProductList { get; set; } = new List<Product>();

        public static List<Product> ProductsStorage = new List<Product>();

        public void OnGet()
        {
            ProductList = ProductsStorage;
        }

        public IActionResult OnPost()
        {
            ProductsStorage.Add(NewProduct);

            ProductList = ProductsStorage;

            ModelState.Clear();

            NewProduct = new Product
            {
                Categories = new List<Category>
                {
                    new Category(),
                    new Category()
                }
            };

            return Page();
        }
    }
}