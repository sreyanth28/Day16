using Microsoft.AspNetCore.Mvc;
using MvcModelBindingDemo.Models;

namespace MvcModelBindingDemo.Controllers
{
    public class UserController : Controller
    {
        // GET: User/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                return View("Result", user);
            }

            return View(user);
        }
    }
}