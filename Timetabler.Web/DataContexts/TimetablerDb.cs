using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Timetabler.Entitities;

namespace Timetabler.Web.DataContexts
{
    public class TimetablerDb : DbContext
    {
        public DbSet<Event> Events
        {
            get;
            set;
        }

        public TimetablerDb() : base("DefaultConnection")
        {
        }
    }
}