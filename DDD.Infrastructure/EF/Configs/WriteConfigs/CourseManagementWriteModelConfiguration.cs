using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.Entities.UserManagement;
using DDD.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Configs.WriteConfigs
{
    internal sealed partial class WriteConfiguration : IEntityTypeConfiguration<Course>,
        IEntityTypeConfiguration<CourseCatalog>, IEntityTypeConfiguration<CourseAttendee>,
        IEntityTypeConfiguration<Lesson>, IEntityTypeConfiguration<Instructor>
    {
        private ValueConverter idConverter = new ValueConverter<BaseId,Guid>(id=> id.Value,id=>new BaseId(id));
        private ValueConverter titleConverter = new ValueConverter<Title, string>(t => t.Value, t => new Title(t));
        private ValueConverter descriptionConverter = new ValueConverter<Description,string>(dsc=>dsc.Value,dsc=>new Description(dsc));



        void IEntityTypeConfiguration<Course>.Configure(EntityTypeBuilder<Course> builder)
        {
            var priceConverter = new ValueConverter<Price, decimal>(p => p.Value, p => new Price(p));

           builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id)
                .HasConversion(idConverter);

            builder.Property(typeof(Title), "_title")
                .HasConversion(titleConverter)
                .HasColumnName("Title")
                .IsRequired();

            builder.Property(typeof(Description), "_description")
                .HasConversion(descriptionConverter)
                .HasColumnName("Description")
                .IsRequired();

            builder.Property(typeof(bool), "_isFree")
                .HasColumnName("IsFree")
                .IsRequired();

            builder.Property(typeof(Price), "_price")
                .HasConversion(priceConverter)
                .HasColumnName("Price");

            builder.Property(typeof(BaseId), "_instructorId")
                .HasConversion(idConverter)
                .HasColumnName("InstructorId");

            builder.HasOne<Instructor>()
                .WithMany()
                .HasForeignKey("_instructorId")
                .IsRequired();

            builder.HasMany(typeof(CourseAttendee), "_courseAttendees")
                .WithOne()
                .HasForeignKey("_courseId");

            builder.ToTable("Course");
        }

        public void Configure(EntityTypeBuilder<CourseCatalog> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasConversion(idConverter);


            builder.Property(typeof(Title), "_title")
              .HasConversion(titleConverter)
              .HasColumnName("Title")
              .IsRequired();

            builder.Property(typeof(Description), "_description")
                .HasConversion(descriptionConverter)
                .HasColumnName("Description")
                .IsRequired();

            builder.Property(typeof(BaseId), "_courseId")
                .HasConversion(idConverter)
                .HasColumnName("CourseId");

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey("_courseId").IsRequired();

            builder.HasMany(typeof(Lesson), "_lessons")
                .WithOne()
                .HasForeignKey("_courseCatalogId");
        }


        public void Configure(EntityTypeBuilder<CourseAttendee> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasConversion(idConverter);

            builder.Property(typeof(BaseId), "_courseId")
                .HasConversion(idConverter)
                .HasColumnName("CourseId");

            builder.Property(typeof(BaseId), "_userId")
             .HasConversion(idConverter)
             .HasColumnName("UserId");


            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey("_userId")
                .IsRequired();


            builder.HasOne<Course>()
               .WithMany()
               .HasForeignKey("_courseId")
               .IsRequired();

            builder.ToTable("CourseAttendees");

        }

        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            var urlConverter = new ValueConverter<VideoUrl,string>(u=>u.Value , u=> new VideoUrl(u));

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasConversion(idConverter);


            builder.Property(typeof(Title), "_title")
              .HasConversion(titleConverter)
              .HasColumnName("Title")
              .IsRequired();

            builder.Property(typeof(VideoUrl), "_videoUrl")
                .HasConversion(urlConverter)
                .HasColumnName("VideoUrl");

            builder.Property(typeof(BaseId), "_courseCatalogId")
                .HasConversion(idConverter)
                .HasColumnName("CourseCatalogId");

            builder.HasOne<CourseCatalog>()
                .WithMany()
                .HasForeignKey("_courseCatalogId")
                .IsRequired();

            builder.ToTable("Lessons");
        }

      
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            var bioConverter = new ValueConverter<Biography, string>(u => u.Value, u => new Biography(u));
            var fullNameConverter = new ValueConverter<FullName, string>(u => u.Value, u => new FullName(u));

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasConversion(idConverter);

            builder.Property(typeof(Biography), "_biography")
                .HasConversion(bioConverter)
                .HasColumnName("Biography");


            builder.Property(typeof(FullName), "_fullName")
           .HasConversion(bioConverter)
           .HasColumnName("FullName");

            builder.Property(typeof(double), "_rating")
                .HasColumnName("Rating")
                ;

            builder.Property(typeof(int), "_experience")
            .HasColumnName("Experience")
            ;

            builder.HasMany(typeof(Course), "_courses")
                .WithOne()
                .HasForeignKey("_instructorId");

            builder.ToTable("Instructors");
        }
    }
}
