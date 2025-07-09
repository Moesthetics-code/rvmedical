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
using APIRvMedical.Models;

namespace APIRvMedical.Controllers
{
    public class spt_fallback_dbController : ApiController
    {
        private masterEntities db = new masterEntities();

        // GET: api/spt_fallback_db
        public IQueryable<spt_fallback_db> Getspt_fallback_db()
        {
            return db.spt_fallback_db;
        }

        // GET: api/spt_fallback_db/5
        [ResponseType(typeof(spt_fallback_db))]
        public IHttpActionResult Getspt_fallback_db(string id)
        {
            spt_fallback_db spt_fallback_db = db.spt_fallback_db.Find(id);
            if (spt_fallback_db == null)
            {
                return NotFound();
            }

            return Ok(spt_fallback_db);
        }

        // PUT: api/spt_fallback_db/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putspt_fallback_db(string id, spt_fallback_db spt_fallback_db)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != spt_fallback_db.xserver_name)
            {
                return BadRequest();
            }

            db.Entry(spt_fallback_db).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!spt_fallback_dbExists(id))
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

        // POST: api/spt_fallback_db
        [ResponseType(typeof(spt_fallback_db))]
        public IHttpActionResult Postspt_fallback_db(spt_fallback_db spt_fallback_db)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.spt_fallback_db.Add(spt_fallback_db);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (spt_fallback_dbExists(spt_fallback_db.xserver_name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = spt_fallback_db.xserver_name }, spt_fallback_db);
        }

        // DELETE: api/spt_fallback_db/5
        [ResponseType(typeof(spt_fallback_db))]
        public IHttpActionResult Deletespt_fallback_db(string id)
        {
            spt_fallback_db spt_fallback_db = db.spt_fallback_db.Find(id);
            if (spt_fallback_db == null)
            {
                return NotFound();
            }

            db.spt_fallback_db.Remove(spt_fallback_db);
            db.SaveChanges();

            return Ok(spt_fallback_db);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool spt_fallback_dbExists(string id)
        {
            return db.spt_fallback_db.Count(e => e.xserver_name == id) > 0;
        }
    }
}