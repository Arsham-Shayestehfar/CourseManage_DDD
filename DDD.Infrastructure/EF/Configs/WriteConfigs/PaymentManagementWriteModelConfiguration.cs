using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.Entities.PaymentManagement;
using DDD.Domain.Entities.UserManagement;
using DDD.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Configs.WriteConfigs
{
    internal sealed partial class WriteConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            var amountConverter = new ValueConverter<Amount, decimal>(a => a.Value, a => new Amount(a));

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                .HasConversion(idConverter);

            builder.Property(typeof(Amount), "_amount")
                .HasConversion(amountConverter)
                .HasColumnName("Amount")
                .IsRequired();

            builder.Property(typeof(DateTime), "_date")
                .HasColumnName("Date");

            builder.Property("_userId")
                .HasConversion(idConverter)
                .HasColumnName("UserId")
                .IsRequired();

            builder.Property("_courseId")
                .HasConversion(idConverter)
                .HasColumnName("CourseId")
                .IsRequired();

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey("_userId");

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey("_courseId");

            builder.ToTable("Invoices");
        }
    }
}
