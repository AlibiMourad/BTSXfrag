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
    public class OoredoesMvcController : Controller
    {
        private WebApplication3Context db = new WebApplication3Context();

        // GET: OoredoesMvc
        public ActionResult Index()
        {
            return View(db.Ooredoes.ToList());
        }

        // GET: OoredoesMvc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ooredo ooredo = db.Ooredoes.Find(id);
            if (ooredo == null)
            {
                return HttpNotFound();
            }
            return View(ooredo);
        }

        // GET: OoredoesMvc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OoredoesMvc/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,x,y,address,title")] Ooredo ooredo)
        {
            if (ModelState.IsValid)
            {
                db.Ooredoes.Add(ooredo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ooredo);
        }

        // GET: OoredoesMvc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ooredo ooredo = db.Ooredoes.Find(id);
            if (ooredo == null)
            {
                return HttpNotFound();
            }
            return View(ooredo);
        }

        // POST: OoredoesMvc/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,x,y,address,title")] Ooredo ooredo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ooredo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ooredo);
        }

        // GET: OoredoesMvc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ooredo ooredo = db.Ooredoes.Find(id);
            if (ooredo == null)
            {
                return HttpNotFound();
            }
            return View(ooredo);
        }

        // POST: OoredoesMvc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ooredo ooredo = db.Ooredoes.Find(id);
            db.Ooredoes.Remove(ooredo);
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
