using System.Web.Mvc;

namespace Tang.Mall.WebUI.Areas.Member
{
    public class MemberAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Member";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Member_default",
                "i/{controller}/{action}/{id}",
                new { controller = "home", action = "Index", id = UrlParameter.Optional },
                new string[] { "Tang.Mall.WebUI.Areas.Member.Controllers" }
            );
        }
    }
}