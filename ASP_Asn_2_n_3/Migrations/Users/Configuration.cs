namespace ASP_Asn_2_n_3.Migrations.Users
{
    using ASP_Asn_2_n_3.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASP_Asn_2_n_3.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Users";
        }

        protected override void Seed(ASP_Asn_2_n_3.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            #region User Seeding
            // Reference
            // http://stackoverflow.com/questions/21170525/cant-connect-to-database-to-execute-identity-functions

            // Begin by creating the new roles
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            RoleManager.Create(new IdentityRole("Administrator"));
            RoleManager.Create(new IdentityRole("Worker"));
            RoleManager.Create(new IdentityRole("Report"));

            // Create the users
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var User = new ApplicationUser() { UserName = "adam@gs.ca", Email = "adam@gs.ca" };
            var Result = UserManager.Create(User, "P@$$w0rd");
            UserManager.AddToRole(User.Id, "Administrator");

            User = new ApplicationUser() { UserName = "wendy@gs.ca", Email = "wendy@gs.ca" };
            Result = UserManager.Create(User, "P@$$w0rd");
            UserManager.AddToRole(User.Id, "Worker");

            User = new ApplicationUser() { UserName = "rob@gs.ca", Email = "rob@gs.ca" };
            Result = UserManager.Create(User, "P@$$w0rd");
            UserManager.AddToRole(User.Id, "Report");
            #endregion
        }
    }
}
