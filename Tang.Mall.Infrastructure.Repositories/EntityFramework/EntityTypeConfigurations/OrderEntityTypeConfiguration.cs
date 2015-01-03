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
    /// 表示对 <c>Ordre</c> 领域模型的实体类型配置。
    /// </summary>
    public class OrderEntityTypeConfiguration : EntityTypeConfiguration<Order>
    {
        /// <summary>
        /// 初始化 <c>OrderEntityTypeConfiguration</c> 类的新实例。
        /// </summary>
        public OrderEntityTypeConfiguration()
        {
            base.Property(m => m.OrderNum)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();

            base.Ignore(m => m.TotalAmount);

            base.HasMany(m => m.OrderItems)
                .WithRequired(m => m.Order)
                .HasForeignKey(m => m.OrderID);
        }
    }
}
