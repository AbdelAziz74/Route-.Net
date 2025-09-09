using Microsoft.AspNetCore.Mvc;
using MVC_03.BLL.Servecies;
namespace MVC_03.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private DepartmentService _departmentService;

        public DepartmentController(DepartmentService departmentService)
          
            => departmentService = departmentService;
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
