using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CollegeManagement.EntryPoints;
using CollegeManagement.ViewModels;
using CollegeManagementCore.Concrete;
using CollegeManagementCore.DAL;
using CollegeManagementCore.Service;
using CollegeManagementCore.Service.Contract;

namespace CollegeManagement.Controllers
{
    public class SubjectController : Controller
    {
        #region Fields 
        public ISubjectService subjectService = EntryPoints<SubjectService>.Service;
        #endregion

        // GET: Subject
        public ActionResult Index()
        {
            return View(subjectService.GetSubjects().ToList());
        }

        // GET: Subject/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = subjectService.GetSubjectById(id.Value);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        // GET: Subject/Create
        public ActionResult Create()
        {
            SubjectViewModel model = new SubjectViewModel();
            return View(model);
        }

        // POST: Subject/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TeacherId,CourseId,SubjectName")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                subjectService.InsertSubject(subject);
                return RedirectToAction("Index");
            }

            return View(subject);
        }

        // GET: Subject/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject=subjectService.GetSubjectById(id.Value);
            if (subject == null)
            {
                return HttpNotFound();
            }
            SubjectViewModel model = new SubjectViewModel();
            model.Subject = subject;
            return View(model);
        }

        // POST: Subject/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TeacherId,CourseId,SubjectName")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                subjectService.UpdateSubject(subject);
                return RedirectToAction("Index");
            }
            return View(subject);
        }

        // GET: Subject/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = subjectService.GetSubjectById(id.Value);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        // POST: Subject/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           
            subjectService.DeleteSubject(id);
            return RedirectToAction("Index");
        }

     
    }
}
