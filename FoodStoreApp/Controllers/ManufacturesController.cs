using FoodStoreApp.Data;
using FoodStoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodStoreApp.Controllers
{
    public class ManufacturesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ManufacturesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Manufactures> manufactureList = _db.Manufactures;
            return View(manufactureList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }


        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Manufactures man)
        {
            if (ModelState.IsValid)
            {
                _db.Manufactures.Add(man);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(man);

        }


        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var man = _db.Manufactures.Find(id);
            if (man == null)
            {
                return NotFound();
            }

            return View(man);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Manufactures man)
        {
            if (ModelState.IsValid)
            {
                _db.Manufactures.Update(man);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(man);

        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var man = _db.Manufactures.Find(id);
            if (man == null)
            {
                return NotFound();
            }

            return View(man);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var man = _db.Manufactures.Find(id);
            if (man == null)
            {
                return NotFound();
            }
            _db.Manufactures.Remove(man);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}