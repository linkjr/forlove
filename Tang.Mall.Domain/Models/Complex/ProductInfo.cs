using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models.Complex
{
    /// <summary>
    /// 表示订单项的商品信息。
    /// </summary>
    public class ProductInfo
    {
        /// <summary>
        /// 获取或设置该订单项对应的商品ID。
        /// </summary>
        public Guid ProductID { get; set; }

        /// <summary>
        /// 获取或设置该订单项对应的商品名称。
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 获取或设置该订单项对应的商品单价。
        /// </summary>
        public decimal UnitPrice { get; set; }
    }
}
