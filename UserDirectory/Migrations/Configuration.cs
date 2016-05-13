namespace UserDirectory.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<UserDirectory.Models.UserDirectoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserDirectoryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new User { FullName = "Andrew Peters" },
            //      new User { FullName = "Brice Lambson" },
            //      new User { FullName = "Rowan Miller" }
            //    );
            //

            context.Users.AddOrUpdate(x => x.UserId,
                new User { Name = "Joa", Surname = "Doa", Email = "joa.doa@joacompany.com", Company = "Joa and Partners Inc." },
                new User { Name = "Job", Surname = "Dob", Email = "job.dob@jobcompany.com", Company = "Job and Partners Inc." },
                new User { Name = "Joc", Surname = "Doc", Email = "joc.doc@joccompany.com", Company = "Joc and Partners Inc." },
                new User { Name = "Jod", Surname = "Dod", Email = "jod.dod@jodcompany.com", Company = "Jod and Partners Inc." },
                new User { Name = "Joe", Surname = "Doe", Email = "joe.doe@joecompany.com", Company = "Joe and Partners Inc." },
                new User { Name = "Jof", Surname = "Dof", Email = "jof.dof@jofcompany.com", Company = "Jof and Partners Inc." },
                new User { Name = "Jog", Surname = "Dog", Email = "jog.dog@jogcompany.com", Company = "Jog and Partners Inc." },
                new User { Name = "Joh", Surname = "Doh", Email = "joh.doh@johcompany.com", Company = "Joh and Partners Inc." },
                new User { Name = "Joi", Surname = "Doi", Email = "joi.doi@joicompany.com", Company = "Joi and Partners Inc." },
                new User { Name = "Joj", Surname = "Doj", Email = "joj.doj@jojcompany.com", Company = "Joj and Partners Inc." },
                new User { Name = "Jok", Surname = "Dok", Email = "jok.dok@jokcompany.com", Company = "Jok and Partners Inc." },
                new User { Name = "Jol", Surname = "Dol", Email = "jol.dol@jolcompany.com", Company = "Jol and Partners Inc." }
                );
        }
    }
}
