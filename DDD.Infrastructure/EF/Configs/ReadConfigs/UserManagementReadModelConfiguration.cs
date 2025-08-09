using DDD.Infrastructure.EF.Models.UserManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Configs.ReadConfigs
{
    internal sealed partial class ReadConfiguration : IEntityTypeConfiguration<UserReadModel>
        ,IEntityTypeConfiguration<RoleReadModel>,IEntityTypeConfiguration<UserRoleReadModel>
    {
        public void Configure(EntityTypeBuilder<UserReadModel> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(t => t.Id);
            builder.Property(u => u.Username).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.IsConfirmed);

            builder.HasMany(u => u.CourseAttendes)
                .WithOne(ca => ca.User)
                .HasForeignKey(ca => ca.UserId);

            builder.HasMany(u=>u.UserRoles)
                .WithOne(ur=>ur.User)
                .HasForeignKey(ur => ur.UserId);

            builder.HasMany(u=>u.Invoices)
                .WithOne(i=>i.User)
                .HasForeignKey(i => i.UserId);

        }

        public void Configure(EntityTypeBuilder<RoleReadModel> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(r => r.Id);
            builder.Property(r=>r.RoleName).IsRequired();

            builder.HasMany(r=>r.UserRoles)
                .WithOne(u => u.Role)
                .HasForeignKey(ur => ur.RoleId);

        }

        public void Configure(EntityTypeBuilder<UserRoleReadModel> builder)
        {
            builder.ToTable("UserRoles");
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });
            builder.HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);
            builder.HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);
        }
    }
}
