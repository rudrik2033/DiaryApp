using DairyApp.Data;
using DairyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DairyApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();

            return View(objDiaryEntryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DiaryEntry Obj)
        {
            if (Obj != null && !string.IsNullOrEmpty(Obj.Title) && Obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }

            if (ModelState.IsValid)
            {
            _db.DiaryEntries.Add(Obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(Obj);
        }
        [HttpGet]
        public IActionResult Edit(int ?id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }
        [HttpPost]
        public IActionResult Edit(DiaryEntry Obj)
        {
            if (Obj != null && !string.IsNullOrEmpty(Obj.Title) && Obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(Obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Obj);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }
        [HttpPost]
        public IActionResult Delete(DiaryEntry Obj)
        {
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Remove(Obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Obj);
        }
    }
}
