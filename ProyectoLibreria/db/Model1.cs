namespace ProyectoLibreria.db
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Coffee> Coffee { get; set; }
        public virtual DbSet<CoffeeType> CoffeeType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Coffee>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Coffee>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Coffee>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<Coffee>()
                .Property(e => e.Price)
                .HasPrecision(9, 2);

            modelBuilder.Entity<CoffeeType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeeType>()
                .HasMany(e => e.Coffee)
                .WithOptional(e => e.CoffeeType)
                .HasForeignKey(e => e.TypeId);
        }
    }
}
