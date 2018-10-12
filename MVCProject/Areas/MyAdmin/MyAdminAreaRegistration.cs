using System.Web.Mvc;

namespace MVCProject.Areas.MyAdmin
{
    public class MyAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MyAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "MyAdmin_default",
                "MyAdmin/{controller}/{action}/{id}",
                new {controller="Accounts", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}