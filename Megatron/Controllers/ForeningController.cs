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
    public class ForeningController : Controller
    {
        private MegatronContext db = new MegatronContext();

        // GET: /Forening/
        public ActionResult Index()
        {
            return View(db.Forenings.ToList());
        }

        // GET: /Forening/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forening forening = db.Forenings.Find(id);
            if (forening == null)
            {
                return HttpNotFound();
            }
            return View(forening);
        }

        // GET: /Forening/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Forening/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Namn")] Forening forening)
        {
            if (ModelState.IsValid)
            {
                db.Forenings.Add(forening);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(forening);
        }

        // GET: /Forening/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forening forening = db.Forenings.Find(id);
            if (forening == null)
            {
                return HttpNotFound();
            }
            return View(forening);
        }

        // POST: /Forening/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Namn")] Forening forening)
        {
            if (ModelState.IsValid)
            {
                db.Entry(forening).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(forening);
        }

        // GET: /Forening/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forening forening = db.Forenings.Find(id);
            if (forening == null)
            {
                return HttpNotFound();
            }
            return View(forening);
        }

        // POST: /Forening/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Forening forening = db.Forenings.Find(id);
            db.Forenings.Remove(forening);
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
