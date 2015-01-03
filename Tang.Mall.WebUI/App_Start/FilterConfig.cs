using System.Web;
using System.Web.Mvc;

using Tang.Mall.Infrastructure.Mvc.Filters;

namespace Tang.Mall.WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleCustomErrorFilterAttribute(), 1);
            filters.Add(new HandleErrorAttribute(), 2);
        }
    }
}
