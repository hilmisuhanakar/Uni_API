using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class UniAtlasDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:uniatlas.database.windows.net,1433;Initial Catalog=UniAtlas;Persist Security Info=False;User ID=o20172013043;Password=BarBarya+627.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<UniDetail> UniDetails { get; set; }
    }
}
