using DDD.Infrastructure.EF.Models.PaymentManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Configs.ReadConfigs
{
    internal sealed partial class ReadConfiguration : IEntityTypeConfiguration<InvoiceReadMoodel>
    {
        public void Configure(EntityTypeBuilder<InvoiceReadMoodel> builder)
        {
            builder.ToTable("Invoices");
            builder.HasKey(x => x.Id);  
            builder.Property(i => i.Amount);
            builder.Property(i => i.Date);
      
            builder.Property(i => i.UserId);
            builder.Property(i => i.CourseId);
            builder.HasOne(i => i.User)
                .WithMany(u=> u.Invoices)
                .HasForeignKey(u=>u.UserId);
            builder.HasOne(i => i.Course)
                .WithMany(c => c.Invoices)
                .HasForeignKey(c=>c.CourseId);
        }
    }
}
