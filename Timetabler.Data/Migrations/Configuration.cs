namespace Timetabler.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using Timetabler.Entitities;

    internal sealed class Configuration : DbMigrationsConfiguration<Timetabler.Data.TimetablerDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Timetabler.Data.TimetablerDb context)
        {
            for (var i = 0; i < 10; i++)
            {
                context.Events.AddOrUpdate(v => v.Description,
                    new Event() { Description = "Stacking Shelves " + i, Title="Stacking", Type = EventType.Lesson});
            }

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
