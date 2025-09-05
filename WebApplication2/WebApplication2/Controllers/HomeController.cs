using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // Get /baseUrl/Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            //var result = new ContentResult();
            //result.Content = "Hello From Index Page";
            ////result.StatusCode = StatusCodes.Status200OK;
            //result.StatusCode = (int)HttpStatusCode.OK;
            //result.ContentType = "text/html";

            //return result;
            //return Content("");

            // Index
            // Views/Home/Index.cshtml
            // Razor View 
            return View();

        }

        //public RedirectResult Update()
        //{
        //    var result = new RedirectResult("https://www.google.com");
        //    return result;
        //}

        public IActionResult Update()
        {
            //var result = new RedirectToActionResult(nameof(ProductsController1.Get), 
            //    "Products", new {id = 10});

            return RedirectToAction("Index");
        }
    }

}
