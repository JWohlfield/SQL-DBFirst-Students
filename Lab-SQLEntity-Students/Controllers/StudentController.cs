using Lab_SQLEntity_Students.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_SQLEntity_Students.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDBContext _studentDB;

        public StudentController(StudentDBContext studentContext)
        {
            _studentDB = studentContext;
        }

        public IActionResult Index()
        {
            return View(_studentDB.Students.ToList());
        }

        public IActionResult Search(int StudentId)
        {
            Student s = _studentDB.Students.Find(StudentId);
            return View(s);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                _studentDB.Students.Add(s);
                _studentDB.SaveChanges();
                //return View();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            Student s = _studentDB.Students.Find(id);
            return View(s);
        }

        [HttpPost]
        public IActionResult Delete(Student s)
        {
            if(ModelState.IsValid)
            {
                _studentDB.Students.Remove(s);
                _studentDB.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Student s = _studentDB.Students.Find(id);
            return View(s);
        }

        [HttpPost]
        public IActionResult Update(Student s)
        {
            if(ModelState.IsValid)
            {
                _studentDB.Students.Update(s);
                _studentDB.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
