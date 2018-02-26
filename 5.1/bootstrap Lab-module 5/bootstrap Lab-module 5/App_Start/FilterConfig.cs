using System.Web;
using System.Web.Mvc;

namespace bootstrap_Lab_module_5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
