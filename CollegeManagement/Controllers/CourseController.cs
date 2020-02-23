using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CollegeManagementCore.Concrete;
using CollegeManagementCore.DAL;
using CollegeManagement.ViewModels;
using CollegeManagementCore.Service.Contract;
using CollegeManagement.EntryPoints;
using CollegeManagementCore.Service;

namespace CollegeManagement.Controllers
{
    public class CourseController : Controller
    {
        #region Fields 
        public ICourseService courseService = EntryPoints<CourseService>.Service;
         #endregion


        // GET: /Course/
        public ViewResult Index()
        {
           return View(courseService.GetCourses().ToList());
        }

        // GET: /Course/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course =courseService.GetCourseByID(id.Value);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Credits")]Course course)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    courseService.InsertCourse(course);
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(course);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = courseService.GetCourseByID(id.Value);
            if (course == null)
            {
                return HttpNotFound();
            }
            
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Credits,Subjects")]Course course)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    courseService.UpdateCourse(course);
                    
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
          
            return View(course);
        }

       

        // GET: /Course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = courseService.GetCourseByID(id.Value);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: /Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            courseService.DeleteCourse(id);
            return RedirectToAction("Index");
        }

       
    }
}
