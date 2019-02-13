using System.Data.Entity.Migrations;

namespace CompleteAutoService.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DB.CompleteAutoServiceContext>
    {
        /// <summary>
        /// configuration constructor
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DB.CompleteAutoServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
