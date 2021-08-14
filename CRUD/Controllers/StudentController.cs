using CRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class StudentController : Controller
    {
        StudentDataAccessLayer studentDataAccessLayer = null;
        public StudentController()
        {
            studentDataAccessLayer = new StudentDataAccessLayer();
        }
        // GET: StudentController
        public ActionResult Index()
        {
            IEnumerable<StudentViewModel> students = studentDataAccessLayer.Read();
            return View(students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            StudentViewModel student = studentDataAccessLayer.GetStudent(id);
            return View(student);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel student)
        {
            try
            {
               studentDataAccessLayer.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            StudentViewModel student = studentDataAccessLayer.GetStudent(id);
            return View(student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentViewModel student)
        {
            try
            {
                studentDataAccessLayer.UpdateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            StudentViewModel student = studentDataAccessLayer.GetStudent(id);
            return View(student);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(StudentViewModel student)
        {
            try
            {
                studentDataAccessLayer.DeleteStudent(student.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
