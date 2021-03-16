using System.Web;
using System.Web.Mvc;

namespace _5851071074_TranNgocTin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
