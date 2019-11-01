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
using TraducaoRelatorios.Models;

namespace TraducaoRelatorios.Controllers
{
    public class BibliotecaMensagensController : ApiController
    {
        private ContextDb db = new ContextDb();

        // GET: api/BibliotecaMensagens
        public IQueryable<BibliotecaMensagem> GetMensagens()
        {
            return db.Mensagens;
        }

        // GET: api/BibliotecaMensagens/5
        [ResponseType(typeof(BibliotecaMensagem))]
        public IHttpActionResult GetBibliotecaMensagem(int id)
        {
            BibliotecaMensagem bibliotecaMensagem = db.Mensagens.Find(id);
            if (bibliotecaMensagem == null)
            {
                return NotFound();
            }

            return Ok(bibliotecaMensagem);
        }

        // PUT: api/BibliotecaMensagens/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBibliotecaMensagem(int id, BibliotecaMensagem bibliotecaMensagem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bibliotecaMensagem.Id)
            {
                return BadRequest();
            }

            db.Entry(bibliotecaMensagem).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BibliotecaMensagemExists(id))
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

        // POST: api/BibliotecaMensagens
        [ResponseType(typeof(BibliotecaMensagem))]
        public IHttpActionResult PostBibliotecaMensagem(BibliotecaMensagem bibliotecaMensagem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Mensagens.Add(bibliotecaMensagem);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bibliotecaMensagem.Id }, bibliotecaMensagem);
        }

        // DELETE: api/BibliotecaMensagens/5
        [ResponseType(typeof(BibliotecaMensagem))]
        public IHttpActionResult DeleteBibliotecaMensagem(int id)
        {
            BibliotecaMensagem bibliotecaMensagem = db.Mensagens.Find(id);
            if (bibliotecaMensagem == null)
            {
                return NotFound();
            }

            db.Mensagens.Remove(bibliotecaMensagem);
            db.SaveChanges();

            return Ok(bibliotecaMensagem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BibliotecaMensagemExists(int id)
        {
            return db.Mensagens.Count(e => e.Id == id) > 0;
        }
    }
}