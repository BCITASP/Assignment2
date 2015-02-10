using System.Web;
using System.Web.Mvc;

namespace ASP_Asn_2_n_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
