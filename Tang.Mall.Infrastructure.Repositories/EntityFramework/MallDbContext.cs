using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tang.Mall.Domain;
using Tang.Mall.Domain.Models;
using Tang.Mall.Domain.Models.Complex;
using Tang.Mall.Infrastructure.Repositories.EntityFramework.ComplexTypeConfigurations;
using Tang.Mall.Infrastructure.Repositories.EntityFramework.EntityTypeConfigurations;

namespace Tang.Mall.Infrastructure.Repositories.EntityFramework
{
    /// <summary>
    /// 表示数据访问上下文类。
    /// </summary>
    public class MallDbContext : DbContext
    {
        public MallDbContext() :
            base(nameOrConnectionString: "SqlConnectionString")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MallDbContext, Migrations.Configuration>());
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressComplexTypeConfiguration());
            modelBuilder.Configurations.Add(new ProductInfoComplexTypeConfiguration());

            modelBuilder.Configurations.Add(new UserEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new SpecificationTypeEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new SpecificationPropertyEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new ProductEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new ProductAttributeEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new ProductSaleEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new ProductSaleSpecificationEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new OrderEntityTypeConfiguration());

            modelBuilder.Properties<DateTime>()
                .Configure(m =>
                    m.HasColumnType("DateTime2")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed));
            modelBuilder.Types()
                .Where(m => m.GetProperties().Where(t => t.Name == "TimeStamp").Any())
                .Configure(m =>
                    m.Property("TimeStamp")
                    .IsRequired());

            base.OnModelCreating(modelBuilder);
        }
    }
}
