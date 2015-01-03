using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tang.Mall.Domain.Models;

namespace Tang.Mall.Infrastructure.Repositories.EntityFramework.EntityTypeConfigurations
{
    /// <summary>
    /// 表示对 <c>ProductSale</c> 领域模型的实体类型配置。
    /// </summary>
    public class ProductSaleEntityTypeConfiguration : EntityTypeConfiguration<ProductSale>
    {
        /// <summary>
        /// 初始化 <c>ProductSaleEntityTypeConfiguration</c> 类的新实例。
        /// </summary>
        public ProductSaleEntityTypeConfiguration()
        {
            base.Property(m => m.MarketPrice)
                .HasColumnType("Money");
            base.Property(m => m.UnitPrice)
                .HasColumnType("Money");
            base.Property(m => m.CostPrice)
                .HasColumnType("Money");

            base.HasRequired(m => m.Product)
                .WithMany(m => m.ProductSales)
                .HasForeignKey(m => m.ProductID);
        }
    }
}
