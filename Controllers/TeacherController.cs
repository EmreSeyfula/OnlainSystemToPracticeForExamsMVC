using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlainSystemToPracticeForExamsMVC.Controllers
{
    public class TeacherController : Controller
    {
        [Authorize(Roles = "Teacher")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
