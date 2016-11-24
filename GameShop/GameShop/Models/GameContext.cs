namespace GameShop.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GameContext : DbContext
    {
        public GameContext()
            : base("name=GameContext")
        {
        }

        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Games>()
                .Property(e => e.Genre)
                .IsUnicode(false);

            modelBuilder.Entity<Games>()
                .Property(e => e.Company)
                .IsUnicode(false);
        }
    }
}
