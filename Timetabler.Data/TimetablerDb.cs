using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Timetabler.Entitities;

namespace Timetabler.Data
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
            Database.Log = sql => Debug.WriteLine(sql);
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // Table names match entity names by default (don't pluralize)
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    // Globally disable the convention for cascading deletes
        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        //    modelBuilder.Entity<Customer>()
        //                .Property(c => c.Id) // Client must set the ID.
        //                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

        //    modelBuilder.Entity<Customer>().Ignore(c => c.FullName);
        //}
    }
}