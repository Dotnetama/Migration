using Microsoft.EntityFrameworkCore;

namespace Single.Data
{
    public class MigDbContext : DbContext
    {
        public MigDbContext(DbContextOptions<MigDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogMaster> BlogMasters { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Table BlogMasters 단수형
            modelBuilder.Entity<BlogMaster>().ToTable("BlogMaster");
            // 복합키 지정
            modelBuilder.Entity<BlogMaster>().HasKey(c => new { c.BlogId, c.PostId });
            // ModifiedDate 기본값 : sysutcdatetime()
            modelBuilder.Entity<BlogMaster>().Property(c => c.ModifiedDate)
                                             .HasDefaultValueSql("sysutcdatetime()");
        }
    }
}
