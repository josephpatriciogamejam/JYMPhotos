namespace MYJ.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MYJ.Services.DTO;

    public partial class MYJContext : DbContext
    {
        public MYJContext()
            : base("name=MYJContext")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
