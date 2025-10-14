using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MVC_03.BLL.Servecies;
namespace MVC_03.PL.Controllers
{
    public class EmployeesController : Controller
    {

        public class EmployeeController(IEmployeeService EmployeeService ILogger<EmployeeController> logger, IWebHostEnvironment env, IMapper mapper) : Controller
        {
            [HttpGet]
            public IActionResult Index()
            {
                var Employees = EmployeeService.GetAll();
                ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                {
                    ["Title"] = "Employees"
                };
                return View(Employees);
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpGet]
            public IActionResult Delete(int? id)
            {
                if (!id.HasValue)
                    return BadRequest();
                var Employee = Service.GetById(id.Value);
                if (Employee is null)
                    return NotFound();
                return View(Employee);
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
