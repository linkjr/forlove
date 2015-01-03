using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Repositories
{
    /// <summary>
    /// 表示继承于该接口的类型是应用于某种聚合根的仓储类型。
    /// </summary>
    /// <typeparam name="TEntity">聚合根类型。</typeparam>
    public interface IRepository<TEntity>
        where TEntity : class, IAggregateRoot
    {
    }
}
