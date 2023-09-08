using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMiniProject.Models;

namespace WebMiniProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplyStatusDbContext applyStatusDb;
        public HomeController(ApplyStatusDbContext applyStatusDb)
        {
            this.applyStatusDb = applyStatusDb;
        }

        public IActionResult Index()
        {
           
            return View();
        }
        
        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUP()
        {
            return View();
        }

        public IActionResult ResumeWrite()
        {
            return View();
        }

        public IActionResult Delete(int? id)
        {
            var applystatusData = this.applyStatusDb.Resume.Find(id);
            if (applystatusData != null) 
            {
                applyStatusDb.Resume.Remove(applystatusData);
            }
            applyStatusDb.SaveChanges();
            return RedirectToAction("ApplyStatus", "Home");
        }
        public IActionResult Corporation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ApplyStatus()
        {
            var applystatusData = this.applyStatusDb.Resume.ToList();
            return View(applystatusData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApplyStatus([Bind(" Title, Content")] ApplyStatus applystatus)
        {
            if (ModelState.IsValid)
            {
                this.applyStatusDb.Add(applystatus);
                await applyStatusDb.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applystatus);
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
