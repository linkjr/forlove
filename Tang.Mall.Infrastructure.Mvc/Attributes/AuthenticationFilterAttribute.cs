using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Tang.Mall.Infrastructure.Mvc.Attributes
{
    /// <summary>
    /// 表示一个特性，该特性用于处理访问认证过滤。
    /// </summary>
    public class AuthenticationFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 在执行操作方法之前由 ASP.NET MVC 框架调用。
        /// </summary>
        /// <param name="filterContext">筛选器上下文。</param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var actionDescriptor = filterContext.ActionDescriptor;
            //判断操作的特性
            var attributes = actionDescriptor.GetCustomAttributes(typeof(AllowAnonymousAttribute), true);
            if (attributes.Length > 0)
            {
                return;
            }
            //判断控制器的特性
            attributes = actionDescriptor.ControllerDescriptor.GetCustomAttributes(typeof(AllowAnonymousAttribute), true);
            if (attributes.Length > 0)
            {
                return;
            }

            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var context = filterContext.HttpContext;
                if (context.Request.IsAjaxRequest())
                {
                    filterContext.Result = new JsonResult
                    {
                        Data = new
                        {
                            result = false,
                            msg = "登录超时，请重新登录"
                        }
                    };
                }
                else
                {
                    var excResult = new RedirectResult("~/account/signin?fromurl=" + context.Server.UrlEncode(context.Request.Url.ToString()));
                    filterContext.Result = excResult;
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
