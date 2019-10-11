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
using BikeshopApp.Models;

namespace BikeshopApp.Controllers
{
    public class BicicletasController : ApiController
    {
        private BikeShopContext db = new BikeShopContext();

        // GET: api/Bicicletas
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return db.Bicicletas;
        }

        // GET: api/Bicicletas/5
        [ResponseType(typeof(Bicicleta))]
        public IHttpActionResult GetBicicleta(int id)
        {
            Bicicleta bicicleta = db.Bicicletas.Find(id);
            if (bicicleta == null)
            {
                return NotFound();
            }

            return Ok(bicicleta);
        }

        // PUT: api/Bicicletas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBicicleta(int id, Bicicleta bicicleta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bicicleta.Id)
            {
                return BadRequest();
            }

            db.Entry(bicicleta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BicicletaExists(id))
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

        // POST: api/Bicicletas
        [ResponseType(typeof(Bicicleta))]
        public IHttpActionResult PostBicicleta(Bicicleta bicicleta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Bicicletas.Add(bicicleta);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bicicleta.Id }, bicicleta);
        }

        // DELETE: api/Bicicletas/5
        [ResponseType(typeof(Bicicleta))]
        public IHttpActionResult DeleteBicicleta(int id)
        {
            Bicicleta bicicleta = db.Bicicletas.Find(id);
            if (bicicleta == null)
            {
                return NotFound();
            }

            db.Bicicletas.Remove(bicicleta);
            db.SaveChanges();

            return Ok(bicicleta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BicicletaExists(int id)
        {
            return db.Bicicletas.Count(e => e.Id == id) > 0;
        }
    }
}