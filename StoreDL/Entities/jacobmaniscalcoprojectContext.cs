using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StoreDL.Entities
{
    public partial class jacobmaniscalcoprojectContext : DbContext
    {
        public jacobmaniscalcoprojectContext()
        {
        }

        public jacobmaniscalcoprojectContext(DbContextOptions<jacobmaniscalcoprojectContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
