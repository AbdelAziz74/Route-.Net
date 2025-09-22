using Microsoft.AspNetCore.Mvc;
using MVC_03.BLL.Servecies;
namespace MVC_03.PL.Controllers
{
    public class EmployeesController : Controller
    {

        public class EmployeeController(IEmployeeService EmployeeService) : Controller
        {
            [HttpGet]
            public IActionResult Index()
            {
                var Employees = EmployeeService.GetAll();
                return View(Employees);
            }

            public IActionResult Create()
            {
                return View();
            }

            private (bool flowControl, IActionResult value) ValidateEmployeeIdAndFetch(int? id, out EmployeeDetailsResponse? Employee)
            {
                if (!id.HasValue)
                {
                    Employee = default;
                    return (flowControl: false, Value: BadRequest());
                }
                Employee = Service.GetById(id.Value);
                if (Employee is null)
                    return (flowControl: false, value: NotFound());
                return (flowControl: true, value: null);
            }
        }
    }
}
