using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using HealthKitService.Models;

namespace HealthKitService.Controllers
{
    public class UserDetailsController : ApiController
    {
        private HealthKitServiceContext db = new HealthKitServiceContext();

        // GET: api/UserDetails
        public IQueryable<UserDetails> GetUserDetails()
        {
            return db.UserDetails;
        }

        // GET: api/UserDetails/5
        [ResponseType(typeof(UserDetails))]
        public async Task<IHttpActionResult> GetUserDetails(int id)
        {
            UserDetails userDetails = await db.UserDetails.FindAsync(id);
            if (userDetails == null)
            {
                return NotFound();
            }

            return Ok(userDetails);
        }

        // PUT: api/UserDetails/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUserDetails(int id, UserDetails userDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userDetails.Id)
            {
                return BadRequest();
            }

            db.Entry(userDetails).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserDetailsExists(id))
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

        // POST: api/UserDetails
        [ResponseType(typeof(UserDetails))]
        public async Task<IHttpActionResult> PostUserDetails(UserDetails userDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserDetails.Add(userDetails);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = userDetails.Id }, userDetails);
        }

        // DELETE: api/UserDetails/5
        [ResponseType(typeof(UserDetails))]
        public async Task<IHttpActionResult> DeleteUserDetails(int id)
        {
            UserDetails userDetails = await db.UserDetails.FindAsync(id);
            if (userDetails == null)
            {
                return NotFound();
            }

            db.UserDetails.Remove(userDetails);
            await db.SaveChangesAsync();

            return Ok(userDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserDetailsExists(int id)
        {
            return db.UserDetails.Count(e => e.Id == id) > 0;
        }
    }
}