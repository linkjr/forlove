using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tang.Mall.Domain.Models.Complex;

namespace Tang.Mall.Domain.Models
{
    /// <summary>
    /// 表示订单项领域实体的类。
    /// </summary>
    public class OrderItem : Entity
    {
        #region ctor

        /// <summary>
        /// 初始化 <c>OrderItem</c> 类的新实例。
        /// </summary>
        public OrderItem()
        {
            this.ProductInfo = new ProductInfo();
        }

        #endregion

        #region Properties

        #region Entity Properties

        /// <summary>
        /// 获取或设置该订单项的商品数量。
        /// </summary>
        public int Quantity { get; private set; }

        /// <summary>
        /// 获取或设置该订单项对应的订单ID。
        /// </summary>
        public Guid OrderID { get; private set; }

        #endregion

        #region Complex Properties

        /// <summary>
        /// 获取或设置该订单项的产品信息。
        /// </summary>
        public ProductInfo ProductInfo { get; private set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// 获取或设置该订单项对应的订单。
        /// </summary>
        public virtual Order Order { get; private set; }

        #endregion

        #endregion
    }
}
