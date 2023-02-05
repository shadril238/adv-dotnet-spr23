using System.Web;
using System.Web.Mvc;

namespace LabTask1_DataPassingLayout
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
