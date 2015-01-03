using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models
{
    /// <summary>
    /// 表示聚合根类型的基类。
    /// </summary>
    public abstract class AggregateRoot : Entity, IAggregateRoot
    {
    }
}
