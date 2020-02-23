using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CollegeManagement.EntryPoints;
using CollegeManagementCore.Concrete;
using CollegeManagementCore.DAL;
using CollegeManagementCore.Service;
using CollegeManagementCore.Service.Contract;

namespace CollegeManagement.Controllers
{
    public class TeacherController : Controller
    {
        #region Fields 
        public ITeacherService teacherService = EntryPoints<TeacherService>.Service;
        #endregion

        // GET: Teacher
        public ActionResult Index()
        {
            return View(teacherService.GetTeachers().ToList());
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = teacherService.GetTeacherById(id.Value);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LastName,FirstMidName,Birthday,Salary")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                teacherService.InsertTeacher(teacher);
                return RedirectToAction("Index");
            }

            return View(teacher);
        }

        // GET: Teacher/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = teacherService.GetTeacherById(id.Value);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teacher/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LastName,FirstMidName,Birthday,Salary")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                teacherService.UpdateTeacher(teacher);
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = teacherService.GetTeacherById(id.Value);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teacher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            teacherService.DeleteTeacher(id);
            return RedirectToAction("Index");
        }
        
    }
}
