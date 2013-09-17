using System.Web;
using System.Web.Mvc;
using MultipleFormsInTheSameViewSample.Filters;

namespace MultipleFormsInTheSameViewSample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new IgnoreModelErrorsAttribute());
        }
    }
}