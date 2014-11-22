using System;
using ServiceStack.Mvc;
using System.Web.Mvc;
using ServiceStack;
using Aicl.Liebre.ServiceInterface;
using Aicl.Liebre.Model;

namespace Mvcprojrazor.Controllers
{
	public class DiagnosticoInfoController:ServiceStackController
	{
		public ActionResult Index ()
		{

			Console.WriteLine (HttpContext);
			Console.WriteLine (this);

			var dto = Request.QueryString.GetDto<DiagnosticoInfo> ();
			Console.WriteLine (dto);
			var id = Request.QueryString["Id"]??Request.QueryString["id"];
			Console.WriteLine (id);

			using (var hello = HostContext.ResolveService<DiagnosticoInfoService>(HttpContext))
			{
				var result = hello.Get(new DiagnosticoInfo{Id=id} );
				Console.WriteLine (result);
				Console.WriteLine (((DiagnosticoInfoResponse) result).Empresa.Nombre );
				return View (result);
			}

		}
	}
}