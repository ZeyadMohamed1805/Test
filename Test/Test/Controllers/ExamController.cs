using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Course(int Id)
        {
            return View();
        }
    }
}
