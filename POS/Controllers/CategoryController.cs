using Microsoft.AspNetCore.Mvc;
using POS.Data;
using POS.Models;
using System.Collections.Generic;

namespace POS.Controllers
{
    public class CategoryController : Controller
    {
        private readonly POSEntities _posEntities;

        public CategoryController(POSEntities POSEntities)
        {
            _posEntities = POSEntities;

        }
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _posEntities.Categories;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _posEntities.Categories.Add(obj);
                _posEntities.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _posEntities.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _posEntities.Categories.Update(obj);
                _posEntities.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _posEntities.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - DELETE
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id, bool notUsed)
        {
            var obj = _posEntities.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _posEntities.Categories.Remove(obj);
            _posEntities.SaveChanges();
            return RedirectToAction("Index");
        }
      
    }
}
