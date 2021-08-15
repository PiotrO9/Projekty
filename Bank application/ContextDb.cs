using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bank_application
{
    public partial class ContextDb : DbContext
    {
        public ContextDb()
            : base("name=ContextDb")
        {
        }

        public virtual DbSet<UserData> UserDatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserData>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
