namespace MYJ.Services.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MYJ.Data.Context.MYJContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MYJ.Data.Context.MYJContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.            
            context.Usuarios.AddOrUpdate(x => x.Id, new DTO.Usuario()
            {
                Id = 1,
                Email = "mail",
                Name = "joseph"                
            });
        }
    }
}
