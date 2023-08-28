using EmptyViewImports02.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyViewImports02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "홍길동", Hp="010-1111-1111"},
                new Student { Id = 1, Name = "강감찬", Hp="010-2222-2222"},
                new Student { Id = 1, Name = "이순신", Hp="010-3333-3333"}
            };
            return View(students);
        }
        public IActionResult About()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "홍길동", Hp="010-1111-1111"},
                new Student { Id = 1, Name = "강감찬", Hp="010-2222-2222"},
                new Student { Id = 1, Name = "이순신", Hp="010-3333-3333"}
            };
            return View(students);
        }
    }
}
