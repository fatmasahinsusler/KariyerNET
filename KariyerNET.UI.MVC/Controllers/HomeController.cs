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
		ILoginService loginService;
		public HomeController(ILoginService LoginService)
		{
			loginService = LoginService;
		}
		public ActionResult Index()
		{
			Login user = new Login()
			{
				LoginMail = "asko",
				Password = "123"
			};

			loginService.Insert(user);
            return View(user);
	}
}
}