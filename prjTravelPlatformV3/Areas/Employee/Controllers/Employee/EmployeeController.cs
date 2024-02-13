using Microsoft.AspNetCore.Mvc;
using prjTravelPlatformV3.Models;

namespace prjTravelPlatformV3.Areas.Employee.Controllers.Employee
{
    [Area("Employee")]
    public class EmployeeController : Controller
    {
        private readonly dbTravalPlatformContext _context;
        public EmployeeController(dbTravalPlatformContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
