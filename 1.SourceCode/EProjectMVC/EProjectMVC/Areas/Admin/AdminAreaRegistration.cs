using System.Web.Mvc;

namespace EProjectMVC.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index",controller="Account", id = UrlParameter.Optional },
                new[] { "EProjectMVC.Areas.Admin.Controllers" }
            );
        }
    }
}