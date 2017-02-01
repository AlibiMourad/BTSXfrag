using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BTSxfrag.Mode;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrangesController : ApiController
    {
        private WebApplication2Context db = new WebApplication2Context();

        // GET: api/Oranges
        public IQueryable<Orange> GetOranges()
        {
            return db.Oranges;
        }

        // GET: api/Oranges/5
        [ResponseType(typeof(Orange))]
        public IHttpActionResult GetOrange(int id)
        {
            Orange orange = db.Oranges.Find(id);
            if (orange == null)
            {
                return NotFound();
            }

            return Ok(orange);
        }

        // PUT: api/Oranges/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrange(int id, Orange orange)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orange.Id)
            {
                return BadRequest();
            }

            db.Entry(orange).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrangeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Oranges
        [ResponseType(typeof(Orange))]
        public IHttpActionResult PostOrange(Orange orange)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Oranges.Add(orange);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = orange.Id }, orange);
        }

        // DELETE: api/Oranges/5
        [ResponseType(typeof(Orange))]
        public IHttpActionResult DeleteOrange(int id)
        {
            Orange orange = db.Oranges.Find(id);
            if (orange == null)
            {
                return NotFound();
            }

            db.Oranges.Remove(orange);
            db.SaveChanges();

            return Ok(orange);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrangeExists(int id)
        {
            return db.Oranges.Count(e => e.Id == id) > 0;
        }
    }
}