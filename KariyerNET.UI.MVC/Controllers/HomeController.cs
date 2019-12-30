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
        ILoginService _loginService;
        public HomeController(ILoginService loginservice)
        {
            _loginService = loginservice;
        }
		public ActionResult Index()
		{
            Login user = new Login()
            {
                LoginMail = "askoyazilim@mail.com",
                Password = "1234"
            };
            //_loginService.Insert(user);
			return View(user);
		}
        
	}
}