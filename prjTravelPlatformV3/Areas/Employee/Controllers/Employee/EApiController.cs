using Microsoft.AspNetCore.Mvc;
using prjTravelPlatformV3.Models;

namespace prjTravelPlatformV3.Areas.Employee.Controllers.Employee
{
    [Route("/api/Employee/{action}/{id?}")]
    public class EApiController : Controller
    {
        private readonly dbTravalPlatformContext _context;

        public EApiController(dbTravalPlatformContext context)
        {
            _context = context;
        }
        public IActionResult GetAll()
        {
            var employees = from e in _context.TEmployees
                         select e;
            return Json(employees);
        }
        public IActionResult GetById(int id)
        {
            var employee = _context.TEmployees.FirstOrDefault(e => e.FEmployeeId == id);
            return Json(employee);
        }
    }
}
