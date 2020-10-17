namespace TrelloToDoList.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using TrelloToDoList.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TrelloToDoList.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrelloToDoList.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            AddUsers(context);
        }
        void AddUsers(TrelloToDoList.Models.ApplicationDbContext context)
        {
            var user = new Models.ApplicationUser { UserName = "nisha@test.org" };
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            um.Create(user, "password");
        }
    }
}
