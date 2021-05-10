using System.Web;
using System.Web.Mvc;

namespace Bai_Tap_Lon
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
