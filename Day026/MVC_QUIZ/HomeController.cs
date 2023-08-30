using Microsoft.AspNetCore.Mvc;
using MVC_203_08_30QUIZ.Models;
using System.Diagnostics;

namespace MVC_203_08_30QUIZ.Controllers
{
    public class HomeController : Controller
    {
        private readonly DiaryDbContext diaryDb;
        public HomeController(DiaryDbContext diaryDb)
        {
            this.diaryDb = diaryDb;
        }

        public IActionResult Index()
        {
            var diaryData = this.diaryDb.Diary.ToList();
            return View(diaryData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind(" Title, Content")] Diary diary)
        {
            if (ModelState.IsValid)
            {
                this.diaryDb.Add(diary);
                await diaryDb.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diary);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Diary() 
        {
            return View();
        }
        [HttpPost] 
        public IActionResult SaveDiary(Diary diary)
        {
            diaryDb.Diary.Add(diary);
            diaryDb.SaveChanges(); // 데이터베이스에 저장
            return RedirectToAction("Result", new { diary });
        }

        public IActionResult Result()
        {
            var diaryData = this.diaryDb.Diary.ToList();
            return View(diaryData);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
