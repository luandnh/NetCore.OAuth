using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using OAuthService.Models;

namespace OAuthService.DbContext
{
    public class OAuthDbContext : IdentityDbContext<OAuthUser, OAuthRole, Guid>
    {
        public OAuthDbContext(DbContextOptions<OAuthDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<OAuthUser>(entity => entity.Property(m => m.Id).HasMaxLength(12));
            builder.Entity<OAuthUser>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(85));
            builder.Entity<OAuthUser>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(85));

            builder.Entity<OAuthRole>(entity => entity.Property(m => m.Id).HasMaxLength(12));
            builder.Entity<OAuthRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(85));

            builder.Entity<IdentityUserLogin<Guid>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            builder.Entity<IdentityUserLogin<Guid>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(85));
            builder.Entity<IdentityUserLogin<Guid>>(entity => entity.Property(m => m.UserId).HasMaxLength(12));
            builder.Entity<IdentityUserRole<Guid>>(entity => entity.Property(m => m.UserId).HasMaxLength(12));

            builder.Entity<IdentityUserRole<Guid>>(entity => entity.Property(m => m.RoleId).HasMaxLength(12));

            builder.Entity<IdentityUserToken<Guid>>(entity => entity.Property(m => m.UserId).HasMaxLength(12));
            builder.Entity<IdentityUserToken<Guid>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            builder.Entity<IdentityUserToken<Guid>>(entity => entity.Property(m => m.Name).HasMaxLength(85));

            builder.Entity<IdentityUserClaim<Guid>>(entity => entity.Property(m => m.Id).HasMaxLength(12));
            builder.Entity<IdentityUserClaim<Guid>>(entity => entity.Property(m => m.UserId).HasMaxLength(12));
            builder.Entity<IdentityRoleClaim<Guid>>(entity => entity.Property(m => m.Id).HasMaxLength(12));
            builder.Entity<IdentityRoleClaim<Guid>>(entity => entity.Property(m => m.RoleId).HasMaxLength(12));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
    public class OAuthDbContextFactory : IDesignTimeDbContextFactory<OAuthDbContext>
    {
        public string GetConnectionString()
        {
            const string databaseServer = "localhost,3306";
            const string databaseName = "db_oauth";
            const string databaseUser = "dbadmin";
            const string databasePass = "123456";

            return $"Server={databaseServer};" +
                   $"database={databaseName};" +
                   $"uid={databaseUser};" +
                   $"pwd={databasePass};" +
                   $"pooling=true;";
        }
        public OAuthDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OAuthDbContext>();
            optionsBuilder.UseMySQL(GetConnectionString());
            return new OAuthDbContext(optionsBuilder.Options);
        }
    }
}
