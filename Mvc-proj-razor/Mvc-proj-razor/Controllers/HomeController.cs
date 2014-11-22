using System.Web.Mvc;
using ServiceStack.Mvc;

namespace Controllers
{
	public class HomeController : ServiceStackController
	{
		public ActionResult Index ()
		{
			return Redirect ("/");
		}
	}
}

