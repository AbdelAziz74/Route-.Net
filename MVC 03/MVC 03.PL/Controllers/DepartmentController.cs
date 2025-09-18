using Microsoft.AspNetCore.Mvc;
using MVC_03.BLL.Servecies;

namespace MVC_03.PL.Controllers
{
    public class DepartmentController (IDepartmentService departmentService) : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var departments = departmentService.GetAll();
            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }
    }

     
}
