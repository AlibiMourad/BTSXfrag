using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTSxfrag.Mode;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrangesMvcController : Controller
    {
        private WebApplication2Context db = new WebApplication2Context();

        // GET: OrangesMvc
        public ActionResult Index()
        {
            return View(db.Oranges.ToList());
        }

        // GET: OrangesMvc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orange orange = db.Oranges.Find(id);
            if (orange == null)
            {
                return HttpNotFound();
            }
            return View(orange);
        }

        // GET: OrangesMvc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrangesMvc/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,x,y,address,title")] Orange orange)
        {
            if (ModelState.IsValid)
            {
                db.Oranges.Add(orange);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orange);
        }

        // GET: OrangesMvc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orange orange = db.Oranges.Find(id);
            if (orange == null)
            {
                return HttpNotFound();
            }
            return View(orange);
        }

        // POST: OrangesMvc/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,x,y,address,title")] Orange orange)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orange).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orange);
        }

        // GET: OrangesMvc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orange orange = db.Oranges.Find(id);
            if (orange == null)
            {
                return HttpNotFound();
            }
            return View(orange);
        }

        // POST: OrangesMvc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Orange orange = db.Oranges.Find(id);
            db.Oranges.Remove(orange);
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
