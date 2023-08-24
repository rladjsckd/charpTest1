using Microsoft.AspNetCore.Mvc;
using MVC_Model03.Models;
using MVC_Model03.Repository;
using System.Diagnostics;

namespace MVC_Model03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }
        public List<Car> getAllStudents() 
        {
            return _studentRepository.getAllStudents();
        }
        public Car getStudent(int id) 
        {
            return _studentRepository.getStudentByID(id);
        }
        public IActionResult Index()
        {
            //Data를 만들자
            //var cars = new List<Car>()
            //{
            //    new Car {ID =1, Brand="그랜저", Speed = 220},
            //    new Car {ID =2, Brand="아반떼", Speed = 200},
            //    new Car {ID =3, Brand="BMW", Speed = 250},
            //};
            ////ViewData 또는 ViewBag ----->Index.cshtml에 보내기
            //ViewData["cars"] = cars;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
