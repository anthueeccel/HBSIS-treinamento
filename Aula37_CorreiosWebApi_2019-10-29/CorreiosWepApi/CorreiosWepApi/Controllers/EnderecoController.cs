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
using CorreiosWepApi.Models;

namespace CorreiosWepApi.Controllers
{
    public class EnderecoController : ApiController
    {
        private EnderecoContext db = new EnderecoContext();

        // GET: api/Endereco
        public IQueryable<Endereco> GetEnderecos()
        {
            return db.Enderecos;
        }


        //Get: api/Endereco/{cep}/Info
        [HttpGet]
        [Route("Api/Endereco/{cep}/Info")]
        public IQueryable<Endereco> EnderecoByCep(string cep)
        {
            return db.Enderecos.Where(c => c.Cep == cep);
        }

        //Get: api/Endereco/{bairro}/Info
        [HttpGet]
        [Route("Api/Endereco/{bairro}/InfoByBairro")]
        public IQueryable<Endereco> EnderecoByBairro(string bairro)
        {
            return db.Enderecos.Where(c => c.Bairro == bairro);
        }


        // GET: api/Endereco/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult GetEndereco(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        // PUT: api/Endereco/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEndereco(int id, Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endereco.Id)
            {
                return BadRequest();
            }

            db.Entry(endereco).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Atualizado com sucesso!");
            //return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Endereco
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult PostEndereco(Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Enderecos.Add(endereco);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = endereco.Id }, endereco);
        }

        // DELETE: api/Endereco/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult DeleteEndereco(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            db.Enderecos.Remove(endereco);
            db.SaveChanges();

            return Ok(endereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnderecoExists(int id)
        {
            return db.Enderecos.Count(e => e.Id == id) > 0;
        }
    }
}