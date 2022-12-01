using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace medical.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<medicine> medicines { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<medicine>()
                .Property(e => e.medicine_name)
                .IsUnicode(false);

            modelBuilder.Entity<medicine>()
                .Property(e => e.user_of_medicine)
                .IsUnicode(false);

            modelBuilder.Entity<medicine>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<medicine>()
                .Property(e => e.expiration_date)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
