using System.Web;
using System.Web.Mvc;

namespace PAW_Tarea2_AdrianAraya
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
