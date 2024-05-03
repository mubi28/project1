// LoginController.cs

using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Login
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // Check username and password against your database or any other authentication mechanism
            if (username == "admin" && password == "password")
            {
                // Authentication successful, redirect to a dashboard or homepage
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                // Authentication failed, return to the login page with an error message
                ViewBag.Error = "Invalid username or password";
                return View();
            }
        }
    }
}
