using System.Web;
using System.Web.Http;
using System.Web.Optimization;

namespace Cmx.Bookings.Site
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}