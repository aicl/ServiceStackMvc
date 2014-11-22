using System.Web.Mvc;
using ServiceStack.Mvc;

namespace Mvcprojrazor.Controllers
{
	public class HomeController : ServiceStackController
	{
		public ActionResult Index ()
		{
			return Redirect ("/");
		}
	}
}

