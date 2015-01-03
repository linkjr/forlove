using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models
{
    /// <summary>
    /// 表示商品领域实体的类。
    /// </summary>
    public class Product : AggregateRoot
    {
        #region ctor

        public Product(string productName, int inventory, string description,
            IList<ProductSale> productSales, IList<ProductAttribute> productAttributes)
        {
            this.ProductName = productName;
            this.Inventory = inventory;
            this.Description = description;

            this.ProductSales = productSales;
            this.ProductAttributes = productAttributes;
        }

        #endregion

        #region Properties

        #region Entity Properties

        /// <summary>
        /// 获取或设置商品名称。
        /// </summary>
        public string ProductName { get; private set; }

        /// <summary>
        /// 获取或设置商品编号。
        /// </summary>
        public string SerialNumber { get; private set; }

        /// <summary>
        /// 获取或设置商品库存。
        /// </summary>
        public int Inventory { get; private set; }

        /// <summary>
        /// 获取或设置商品描述信息。
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// 获取或设置商品封面图片。
        /// </summary>
        public string CoverImg { get; private set; }

        /// <summary>
        /// 获取或设置商品备注。
        /// </summary>
        public string Remark { get; private set; }

        /// <summary>
        /// 获取或设置商品截止时间。
        /// </summary>
        public DateTime? Deadline { get; private set; }

        /// <summary>
        /// 获取或设置是否上架商品。
        /// <para>sadf</para>
        /// </summary>
        public bool IsShelved { get; private set; }

        /// <summary>
        /// 获取或设置是否启用商品。
        /// </summary>
        public bool IsEnabled { get; private set; }

        /// <summary>
        /// 获取或设置时间戳。
        /// </summary>
        public byte[] TimeStamp { get; private set; }

        /// <summary>
        /// 获取或设置创建日期。
        /// </summary>
        public DateTime CreateDate { get; private set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// 获取或设置商品销售集合。
        /// </summary>
        public virtual IList<ProductSale> ProductSales { get; private set; }

        /// <summary>
        /// 获取或设置商品属性集合。
        /// </summary>
        public virtual IList<ProductAttribute> ProductAttributes { get; private set; }

        #endregion

        #endregion

        #region Public Properties


        #endregion
    }
}
