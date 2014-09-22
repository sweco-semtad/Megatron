using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Megatron.DataModels.Model;
using Megatron.Models;

namespace Megatron.Controllers
{
    public class FormularController : Controller
    {
        private MegatronContext db = new MegatronContext();

        // GET: /Formular/
        public ActionResult Index()
        {
            return View(db.Formulars.ToList());
        }

        // GET: /Formular/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Formular formular = db.Formulars.Find(id);
            if (formular == null)
            {
                return HttpNotFound();
            }
            return View(formular);
        }

        // GET: /Formular/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Formular/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Namn,Grundpris")] Formular formular)
        {
            if (ModelState.IsValid)
            {
                db.Formulars.Add(formular);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(formular);
        }

        // GET: /Formular/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Formular formular = db.Formulars.Find(id);
            if (formular == null)
            {
                return HttpNotFound();
            }
            return View(formular);
        }

        // POST: /Formular/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Namn,Grundpris")] Formular formular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formular).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(formular);
        }

        // GET: /Formular/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Formular formular = db.Formulars.Find(id);
            if (formular == null)
            {
                return HttpNotFound();
            }
            return View(formular);
        }

        // POST: /Formular/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Formular formular = db.Formulars.Find(id);
            db.Formulars.Remove(formular);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
