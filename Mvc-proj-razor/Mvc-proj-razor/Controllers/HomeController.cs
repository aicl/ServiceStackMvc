using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using ServiceStack.Mvc;
using Aicl.Liebre.Model;

namespace Mvcprojrazor.Controllers
{
	public class HomeController : ServiceStackController
	{
		public ActionResult Index ()
		{
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";
			ViewData ["Empresa"] = new Empresa{ Nombre="Alguna Empresa"};

			return View ( );
		}
	}
}

