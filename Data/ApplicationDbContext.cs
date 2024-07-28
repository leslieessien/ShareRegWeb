using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShareRegWeb.Models;

namespace ShareRegWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankBranch> BankBranches { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("dbo");
            builder.Entity<ApplicationUser>
                (
                entity =>
                {
                    entity.ToTable(name:"Users");
                }
                    
                );

            builder.Entity<IdentityRole>
                (
                entity =>
                {
                    entity.ToTable(name: "Roles");
                }

                );
            builder.Entity<IdentityUserRole<string>>
                (
                entity =>
                {
                    entity.ToTable(name: "UserRoles");
                }

                );
            builder.Entity<IdentityUserClaim<string>>
                (
                entity =>
                {
                    entity.ToTable(name: "UserClaims");
                }

                );
            builder.Entity<IdentityUserLogin<string>>
                (
                entity =>
                {
                    entity.ToTable(name: "UserLogins");
                }

                );
            builder.Entity<IdentityRoleClaim<string>>
                (
                entity =>
                {
                    entity.ToTable(name: "RoleClaims");
                }

                );
            builder.Entity<IdentityUserToken<string>>
                (
                entity =>
                {
                    entity.ToTable(name: "UserTokens");
                }

                );
        }


    }
}
