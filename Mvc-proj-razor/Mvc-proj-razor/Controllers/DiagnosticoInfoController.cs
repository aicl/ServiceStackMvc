﻿using System;
using ServiceStack.Mvc;
using System.Web.Mvc;
using ServiceStack;
using Aicl.Liebre.ServiceInterface;
using Aicl.Liebre.Model;

namespace Controllers
{
	public class DiagnosticoInfoController:ServiceStackController
	{
		public ActionResult Index ()
		{
			var id = Request.QueryString["Id"]??Request.QueryString["id"];
			using (var hello = HostContext.ResolveService<DiagnosticoInfoService>(HttpContext))
			{
				var result = hello.Get(new DiagnosticoInfo{Id=id} );
				return View (result);
			}
		}
	}
}