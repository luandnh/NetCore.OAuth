using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OAuthService.Models.Entities
{
    public partial class db_oauthContext : DbContext
    {
        public db_oauthContext()
        {
        }

        public db_oauthContext(DbContextOptions<db_oauthContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Roleclaim> Roleclaim { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Userclaim> Userclaim { get; set; }
        public virtual DbSet<Userlogin> Userlogin { get; set; }
        public virtual DbSet<Userrole> Userrole { get; set; }
        public virtual DbSet<Usertoken> Usertoken { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=dbadmin;password=123456;database=db_oauth");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(12);

                entity.Property(e => e.ConcurrencyStamp).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Description).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DisplayName).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NormalizedName)
                    .HasMaxLength(85)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Roleclaim>(entity =>
            {
                entity.ToTable("roleclaim");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleClaim_RoleId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClaimType).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClaimValue).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Roleclaim)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleClaim_Role_RoleId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(12);

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.ConcurrencyStamp).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmailConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.LockoutEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.LockoutEnd).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NormalizedEmail)
                    .HasMaxLength(85)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NormalizedUserName)
                    .HasMaxLength(85)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PasswordHash).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhoneNumber).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhoneNumberConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.SecurityStamp).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TwoFactorEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Userclaim>(entity =>
            {
                entity.ToTable("userclaim");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserClaim_UserId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClaimType).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClaimValue).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userclaim)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserClaim_User_UserId");
            });

            modelBuilder.Entity<Userlogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PRIMARY");

                entity.ToTable("userlogin");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserLogin_UserId");

                entity.Property(e => e.LoginProvider)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderKey)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderDisplayName).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userlogin)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserLogin_User_UserId");
            });

            modelBuilder.Entity<Userrole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY");

                entity.ToTable("userrole");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_UserRole_RoleId");

                entity.Property(e => e.UserId).HasMaxLength(12);

                entity.Property(e => e.RoleId).HasMaxLength(12);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Userrole)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRole_Role_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userrole)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRole_User_UserId");
            });

            modelBuilder.Entity<Usertoken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PRIMARY");

                entity.ToTable("usertoken");

                entity.Property(e => e.UserId).HasMaxLength(12);

                entity.Property(e => e.LoginProvider)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Usertoken)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserToken_User_UserId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
