using System.Web;
using System.Web.Mvc;

namespace Beeline.Apps.MvcFive
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
