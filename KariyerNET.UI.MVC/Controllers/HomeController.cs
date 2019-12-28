using KariyerNET.BLL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KariyerNET.UI.MVC.Controllers
{
	public class HomeController : Controller
	{	
		public ActionResult Index()
		{
			return View();
		}
	}
}