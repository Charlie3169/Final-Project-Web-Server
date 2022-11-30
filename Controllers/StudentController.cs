using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext context;

        public StudentController(StudentContext ctx) { context = ctx;  }
        public IActionResult Index()
        {
            // return RedirectToAction("List", "Product");
            return View();
        }

        [Route("[controller]s/{StudentId?}")]
        public IActionResult List(string StudentId = "All")
        {
            var students = context.Students
                .OrderBy(c => c.StudentId).ToList();

            ViewBag.Students = students;

            // bind products to view
            return View(students);
        }

       /* public IActionResult Details(int StudentId)
        {
            var students = context.Students
                .OrderBy(c => c.StudentId).ToList();

            Student student = context.Students.Find(StudentId);

            // string imageFilename = product.Code + "_m.png";

            // use ViewBag to pass data to view
            ViewBag.Students = students;
            //ViewBag.ImageFilename = imageFilename;

            // bind product to view
            return View(student);
        }*/

    }
}
