using DDD.Infrastructure.EF.Configs.ReadConfigs;
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
    internal sealed class ReadDbContext : DbContext
    {
        #region courseManagement dbSets

        public DbSet<CourseReadModel> Courses { get; set; }
        public DbSet<CourseCatalogReadModel> CourseCatalogs { get; set; }
        public DbSet<CourseAttendeReadModel> CourseAttendes { get; set; }
        public DbSet<InstructorReadModel> Instructors { get; set; }
        public DbSet<LessonReadModel> Lessons { get; set; }
        #endregion
        #region UserManagement dbSets

        public DbSet<UserReadModel> Users { get; set; }
        public DbSet<RoleReadModel> Roles { get; set; }
        public DbSet<UserRoleReadModel> UserRoles { get; set; }

        #endregion

        #region PaymentManagement dbSets

        public DbSet<InvoiceReadMoodel> Invoices { get; set; }
        
        #endregion

        public ReadDbContext(DbContextOptions<ReadDbContext> options) :base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var configuration = new ReadConfiguration();

            #region courseManagement Configs
            modelBuilder.ApplyConfiguration<CourseReadModel>(configuration);
            modelBuilder.ApplyConfiguration<CourseCatalogReadModel>(configuration);

            modelBuilder.ApplyConfiguration<CourseAttendeReadModel>(configuration);
            modelBuilder.ApplyConfiguration<LessonReadModel>(configuration);
            modelBuilder.ApplyConfiguration<InstructorReadModel>(configuration);

            #endregion

            #region UserManagement Configs
            modelBuilder.ApplyConfiguration<UserReadModel>(configuration);
            modelBuilder.ApplyConfiguration<RoleReadModel>(configuration);
            modelBuilder.ApplyConfiguration<UserRoleReadModel>(configuration);
            #endregion

            #region PaymentManagement Configs

            modelBuilder.ApplyConfiguration<InvoiceReadMoodel>(configuration);
            #endregion

        }
    }
}
