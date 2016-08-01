namespace RestaurantAssign2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Menu : DbContext
    {
        public Menu()
            : base("name=Menu")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.image)
                .IsUnicode(false);
        }
    }
}
