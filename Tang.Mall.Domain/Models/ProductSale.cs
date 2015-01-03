using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models
{
    /// <summary>
    /// 表示商品销售领域实体的类。
    /// </summary>
    public class ProductSale : Entity
    {
        #region Entity Properties

        /// <summary>
        /// 获取或设置商品市场价格
        /// </summary>
        public decimal? MarketPrice { get; private set; }

        /// <summary>
        /// 获取或设置商品单价。
        /// </summary>
        public decimal UnitPrice { get; private set; }

        /// <summary>
        /// 获取或设置商品成本价格。
        /// </summary>
        public decimal CostPrice { get; private set; }

        /// <summary>
        /// 获取或设置商品库存。
        /// </summary>
        public int Inventory { get; private set; }

        /// <summary>
        /// 获取或设置商品ID。
        /// </summary>
        public Guid ProductID { get; private set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// 获取或设置商品销售规格集合。
        /// </summary>
        public virtual IList<ProductSaleSpecification> ProductSaleSpecifications { get; private set; }

        /// <summary>
        /// 获取或设置对应的商品。
        /// </summary>
        public virtual Product Product { get; private set; }

        #endregion
    }
}
