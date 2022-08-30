using System.Web;
using System.Web.Mvc;

namespace iftekhar_0400034815
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
