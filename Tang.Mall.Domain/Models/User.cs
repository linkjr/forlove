using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models
{
    public class User : AggregateRoot
    {
        /// <summary>
        /// 获取或设置登录账户。
        /// </summary>
        public string Account { get; private set; }

        /// <summary>
        /// 获取或设置登录密码。
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// 获取或设置电子邮件。
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// 获取或设置时间戳。
        /// </summary>
        public byte[] TimeStamp { get; private set; }

        /// <summary>
        /// 获取或设置创建日期。
        /// </summary>
        public DateTime CreateDate { get; private set; }
    }
}
