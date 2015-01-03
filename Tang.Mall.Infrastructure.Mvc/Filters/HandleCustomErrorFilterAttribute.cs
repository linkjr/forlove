using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

using Tang.Mall.Infrastructure.Exceptions;

namespace Tang.Mall.Infrastructure.Mvc.Filters
{
    /// <summary>
    /// 表示一个特性，该特性用于处理并过滤由操作方法引发的异常。
    /// </summary>
    public class HandleCustomErrorFilterAttribute : FilterAttribute, IExceptionFilter
    {
        /// <summary>
        /// 在发生异常时调用。
        /// </summary>
        /// <param name="filterContext">筛选器上下文。</param>
        [ValidateInput(false)]
        public void OnException(ExceptionContext filterContext)
        {
            var exception = filterContext.Exception;
            if (exception != null)
            {
                #region 日志记录

                if (!(exception is ValidationException))
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + "Logs/" + DateTime.Now.ToString("yyyyMMdd");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    var msg = string.Format("{0}\r\n异常消息：{1}\r\n异常方法：{2}\r\n异常类型：{3}",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        exception.GetBaseException().Message,
                        filterContext.Controller.GetType().FullName + "." + filterContext.Exception.TargetSite.Name,
                        exception.GetBaseException().GetType().ToString());
                    using (var sw = File.CreateText(path + "/" + DateTime.Now.ToString("HHmmssffff") + ".txt"))
                    {
                        sw.Write(msg);
                    }
                }

                #endregion

                #region 错误过滤

                var msgTmp = string.Empty;
                var context = filterContext.HttpContext;
                if (context.Request.IsAjaxRequest())
                {
                    if (exception is ValidationException)
                        msgTmp = "{0}";//如果是验证类异常，就显示异常消息
                    else
                        msgTmp = "服务器正忙，请稍后再试";
                    //msgTmp = "$.jBox.info('{0}');";

                    var objs = filterContext.Exception.TargetSite.GetCustomAttributes(typeof(HttpPostAttribute), true);
                    if (objs != null && objs.Length > 0)
                    {
                        filterContext.Result = new ContentResult
                        {
                            //Content = "window.setTimeout(function () { common.Error('" + String.Format(msgTmp, filterContext.Exception.GetBaseException().Message) + "'); }, 1000);",
                            Content = "common.Error('" + String.Format(msgTmp, filterContext.Exception.GetBaseException().Message) + "');",
                            ContentType = "application/x-javascript"
                        };
                    }
                    else
                    {
                        filterContext.Result = new JsonResult
                        {
                            Data = new
                            {
                                result = false,
                                msg = string.Format(msgTmp, exception.GetBaseException().Message)
                            }
                        };
                    }
                }
                else
                {
                    msgTmp = "异常消息：{0}<br/>异常方法：{1}<br/>异常类型：{2}";

                    filterContext.Result = new ContentResult
                    {
                        Content = String.Format(msgTmp,
                            exception.GetBaseException().Message,
                            filterContext.Controller.GetType().FullName + "." + filterContext.Exception.TargetSite.Name,
                            exception.GetBaseException().GetType().ToString())
                    };
                }

                #endregion

                filterContext.ExceptionHandled = true;
            }
        }
    }
}
