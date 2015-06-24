using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Description;
using Timetabler.Data;
using Timetabler.Entitities;

namespace Timetabler.Web.Controllers
{
    public class EventsController : ApiController
    {
        private TimetablerDb _db;// = new TimetablerDb();

        public EventsController(TimetablerDb db)
        {
            _db = db;
        }

        // GET: api/Events
        public async Task<IList<Event>> GetEvents()
        {
            return await _db.Events.ToListAsync();
        }

        [Route("api/events/byservice")]
        public async Task<List<EventService.Event>> GetEventsByService()
        {
            var foo = new EventService.EventsServiceClient();
            var result =  await foo.GetEventsAsync();

            return result.ToList();
        }

        // GET: api/Events/5
        [ResponseType(typeof(Event))]
        public IHttpActionResult GetEvent(long id)
        {
            Event @event = _db.Events.Find(id);
            if (@event == null)
            {
                return NotFound();
            }

            return Ok(@event);
        }

        // PUT: api/Events/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEvent(long id, Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @event.Id)
            {
                return BadRequest();
            }

            _db.Entry(@event).State = EntityState.Modified;

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
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

        // POST: api/Events
        [ResponseType(typeof(Event))]
        public IHttpActionResult PostEvent(Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Events.Add(@event);
            _db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = @event.Id }, @event);
        }

        // DELETE: api/Events/5
        [ResponseType(typeof(Event))]
        public IHttpActionResult DeleteEvent(long id)
        {
            Event @event = _db.Events.Find(id);
            if (@event == null)
            {
                return NotFound();
            }

            _db.Events.Remove(@event);
            _db.SaveChanges();

            return Ok(@event);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventExists(long id)
        {
            return _db.Events.Count(e => e.Id == id) > 0;
        }
    }
}