using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Timetabler.Data;
using Timetabler.Entitities;

using System.Data.Entity;

namespace Timetabler.WCF
{
    public class EventsService : IEventsService
    {
        public async Task<List<Event>> GetEvents()
        {
            TimetablerDb db = new TimetablerDb();




            return await db.Events.ToListAsync();
        }
    }
}
