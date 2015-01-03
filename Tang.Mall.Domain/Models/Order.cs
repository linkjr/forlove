using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models
{
    /// <summary>
    /// 表示订单领域实体的类。
    /// </summary>
    public class Order : AggregateRoot
    {
        /// <summary>
        /// 初始化 <c>Order</c> 类的新实例。
        /// </summary>
        public Order(string orderNum, IList<OrderItem> orderItems)
            : base()
        {
            if (string.IsNullOrEmpty(orderNum) || orderItems == null || orderItems.Count == 0)
                throw new ArgumentException();

            this.OrderNum = orderNum;
            this.OrderItems = orderItems;
        }

        #region Properties

        #region Entity Properties

        /// <summary>
        /// 获取或设置订单编号。
        /// </summary>
        public string OrderNum { get; private set; }

        /// <summary>
        /// 获取或设置订单的状态。
        /// </summary>
        public OrderStatus Status { get; private set; }

        /// <summary>
        /// 获取或设置订单付款日期。
        /// </summary>
        public DateTime? PayDate { get; private set; }

        /// <summary>
        /// 获取或设置拣货日期。
        /// </summary>
        public DateTime? PickDate { get; private set; }

        /// <summary>
        /// 获取或设置订单发货日期。
        /// </summary>
        public DateTime? DispatchDate { get; private set; }

        /// <summary>
        /// 获取或设置订单交付日期。
        /// </summary>
        public DateTime? DeliveredDate { get; private set; }

        /// <summary>
        /// 获取或设置时间戳。
        /// </summary>
        public byte[] TimeStamp { get; private set; }

        /// <summary>
        /// 获取或设置用户ID。
        /// </summary>
        public Guid UserID { get; private set; }

        /// <summary>
        /// 获取或设置订单创建日期。
        /// </summary>
        public DateTime CreateDate { get; private set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// 获取或设置该订单对应的订单项的集合。
        /// </summary>
        public virtual IList<OrderItem> OrderItems { get; private set; }

        #endregion

        #region Extension Properties

        /// <summary>
        /// 获取或设置订单总金额。
        /// </summary>
        public decimal TotalAmount
        {
            get
            {
                return this.OrderItems.Sum(m => m.ProductInfo.UnitPrice * m.Quantity);
            }
        }

        /// <summary>
        /// 获取一个 <see cref="Boolean"/> 值，该值表示当前订单是否已创建。
        /// </summary>
        public bool IsCreated
        {
            get { return this.Status == OrderStatus.Created; }
        }

        /// <summary>
        /// 获取一个 <see cref="Boolean"/> 值，该值表示当前订单是否已付款。
        /// </summary>
        public bool IsPaid
        {
            get { return this.Status == OrderStatus.Paid; }
        }

        /// <summary>
        /// 获取一个 <see cref="Boolean"/> 值，该值表示当前订单是否已拣货。
        /// </summary>
        public bool IsPicked
        {
            get { return this.Status == OrderStatus.Picked; }
        }

        /// <summary>
        /// 获取一个 <see cref="Boolean"/> 值，该值表示当前订单是否已发货。
        /// </summary>
        /// <returns></returns>
        public bool IsDispatched
        {
            get { return this.Status == OrderStatus.Dispatched; }
        }

        /// <summary>
        /// 获取一个 <see cref="Boolean"/> 值，该值表示当前订单是否已交付。
        /// </summary>
        public bool IsDelivered
        {
            get { return this.Status == OrderStatus.Delivered; }
        }

        #endregion

        #endregion

        #region Public Methods

        /// <summary>
        /// 订单创建。
        /// </summary>
        public void Created()
        {
            this.Status = OrderStatus.Created;
            this.CreateDate = DateTime.Now;
        }

        /// <summary>
        /// 订单支付。
        /// </summary>
        public void Paid()
        {
            if (!this.IsCreated)
                throw new InvalidOperationException();

            this.Status = OrderStatus.Paid;
            this.PayDate = DateTime.Now;
        }

        /// <summary>
        /// 订单拣货。
        /// </summary>
        public void Picked()
        {
            if (!this.IsPaid)
                throw new InvalidOperationException();

            this.Status = OrderStatus.Picked;
            this.PayDate = DateTime.Now;
        }

        /// <summary>
        /// 订单发货。
        /// </summary>
        public void Dispatched()
        {
            if (!this.IsPicked)
                throw new InvalidOperationException();

            this.Status = OrderStatus.Dispatched;
            this.PayDate = DateTime.Now;
        }

        /// <summary>
        /// 订单交付。
        /// </summary>
        public void Delivered()
        {
            if (!this.IsDispatched)
                throw new InvalidOperationException();

            this.Status = OrderStatus.Delivered;
            this.PayDate = DateTime.Now;
        }

        #endregion
    }

    /// <summary>
    /// 表示 <c>Order</c> 的生命周期中的当前阶段。
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// 表示订单已创建。
        /// </summary>
        [Description("已创建")]
        Created = 1,
        /// <summary>
        /// 表示订单已付款。
        /// </summary>
        [Description("已付款")]
        Paid,
        /// <summary>
        /// 表示订单已拣货。
        /// </summary>
        [Description("已拣货")]
        Picked,
        /// <summary>
        /// 表示订单已发货。
        /// </summary>
        [Description("已发货")]
        Dispatched,
        /// <summary>
        /// 表示订单已交付。
        /// </summary>
        [Description("已交付")]
        Delivered
    }
}
