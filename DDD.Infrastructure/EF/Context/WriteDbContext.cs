using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.Entities.PaymentManagement;
using DDD.Domain.Entities.UserManagement;
using DDD.Infrastructure.EF.Configs.WriteConfigs;
using DDD.Infrastructure.EF.Models.CourseManagement;
using DDD.Infrastructure.EF.Models.PaymentManagement;
using DDD.Infrastructure.EF.Models.UserManagement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.EF.Context
{
    public sealed class WriteDbContext :DbContext
    {

        #region courseManagement dbSets

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCatalog> CourseCatalogs { get; set; }
        public DbSet<CourseAttendee> CourseAttendes { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        #endregion
        #region UserManagement dbSets

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        #endregion

        #region PaymentManagement dbSets

        public DbSet<Invoice> Invoices { get; set; }

        #endregion


        public WriteDbContext(DbContextOptions<WriteDbContext> options):base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           var configuration = new WriteConfiguration();


            modelBuilder.ApplyConfiguration<Course>(configuration);
            modelBuilder.ApplyConfiguration<CourseCatalog>(configuration);
            modelBuilder.ApplyConfiguration<CourseAttendee>(configuration);
            modelBuilder.ApplyConfiguration<Instructor>(configuration);
            modelBuilder.ApplyConfiguration<Lesson>(configuration);


            modelBuilder.ApplyConfiguration<User>(configuration);
            modelBuilder.ApplyConfiguration<Role>(configuration);
            modelBuilder.ApplyConfiguration<UserRole>(configuration);

            modelBuilder.ApplyConfiguration<Invoice>(configuration);
        }
    }
}
