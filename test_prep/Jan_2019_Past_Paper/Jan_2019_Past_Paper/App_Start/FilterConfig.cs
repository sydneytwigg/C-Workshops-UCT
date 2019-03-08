using System.Web;
using System.Web.Mvc;

namespace Jan_2019_Past_Paper
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
