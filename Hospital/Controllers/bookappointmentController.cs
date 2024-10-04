using Hospital.data;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class bookappointmentController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
            var doctors = dbContext.doctors.ToList();
            return View(model:doctors);
        }
        public IActionResult details(int id)
        {
            var doctorname = dbContext.doctors.Find(id);
            return View(doctorname);
        }
    }
}
