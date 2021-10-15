using inandout.Data;
using inandout.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Controllers
{
    public class ExpenseCategoriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExpenseCategoriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            IEnumerable<ExpenseCategory> objList = _db.ExpenseCategories;
            return View(objList);
        }

        //GET-CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST-CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseCategories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }


        //GET-UPDATE
        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExpenseCategories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST-UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExpenseCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseCategories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }





        //GET-DELETE
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExpenseCategories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST-DELETE

        public IActionResult DeletePost(int? id)
        {
            var obj = _db.ExpenseCategories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.ExpenseCategories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
    }
