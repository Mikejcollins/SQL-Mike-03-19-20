using System.Web;
using System.Web.Mvc;

namespace SQL_Mike_03_19_20
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
