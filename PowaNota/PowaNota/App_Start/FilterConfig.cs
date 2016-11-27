using System.Web;
using System.Web.Mvc;
using PowaNota.Filtro;

namespace PowaNota
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthFilter());
        }
    }
}
