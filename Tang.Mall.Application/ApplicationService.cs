﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tang.Mall.Domain.Repositories;
using Tang.Mall.IApplication;

namespace Tang.Mall.Application
{
    public class ApplicationService : IApplicationService
    {
        private readonly IRepositoryContext _context;

        /// <summary>
        /// 初始化 <c>ApplicationService</c> 类的新实例。
        /// </summary>
        /// <param name="context"></param>
        public ApplicationService(IRepositoryContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// 获取仓储上下文。
        /// </summary>
        protected IRepositoryContext Context
        {
            get { return _context; }
        }
    }
}
