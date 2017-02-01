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
    public class TunisieTelecomsMvcController : Controller
    {
        private WebApplication1Context db = new WebApplication1Context();

        // GET: TunisieTelecomsMvc
        public ActionResult Index()
        {
            return View(db.TunisieTelecoms.ToList());
        }

        // GET: TunisieTelecomsMvc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TunisieTelecom tunisieTelecom = db.TunisieTelecoms.Find(id);
            if (tunisieTelecom == null)
            {
                return HttpNotFound();
            }
            return View(tunisieTelecom);
        }

        // GET: TunisieTelecomsMvc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TunisieTelecomsMvc/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,x,y,address,title")] TunisieTelecom tunisieTelecom)
        {
            if (ModelState.IsValid)
            {
                db.TunisieTelecoms.Add(tunisieTelecom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tunisieTelecom);
        }

        // GET: TunisieTelecomsMvc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TunisieTelecom tunisieTelecom = db.TunisieTelecoms.Find(id);
            if (tunisieTelecom == null)
            {
                return HttpNotFound();
            }
            return View(tunisieTelecom);
        }

        // POST: TunisieTelecomsMvc/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,x,y,address,title")] TunisieTelecom tunisieTelecom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tunisieTelecom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tunisieTelecom);
        }

        // GET: TunisieTelecomsMvc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TunisieTelecom tunisieTelecom = db.TunisieTelecoms.Find(id);
            if (tunisieTelecom == null)
            {
                return HttpNotFound();
            }
            return View(tunisieTelecom);
        }

        // POST: TunisieTelecomsMvc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TunisieTelecom tunisieTelecom = db.TunisieTelecoms.Find(id);
            db.TunisieTelecoms.Remove(tunisieTelecom);
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
