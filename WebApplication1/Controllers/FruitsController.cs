using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class FruitsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Fruits
        public ActionResult Index()
        {
            return View(db.Fruits.ToList());
        }

        // GET: Fruits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // GET: Fruits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fruits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Fruit fruit)
        {
            if (ModelState.IsValid)
            {
                db.Fruits.Add(fruit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fruit);
        }

        // GET: Fruits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // POST: Fruits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Fruit fruit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fruit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fruit);
        }

        // GET: Fruits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // POST: Fruits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fruit fruit = db.Fruits.Find(id);
            db.Fruits.Remove(fruit);
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
