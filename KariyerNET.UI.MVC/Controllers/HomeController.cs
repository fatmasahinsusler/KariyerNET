using KariyerNET.BLL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using KariyerNET.UI.MVC.CustomFilter;
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
            return View();
        }

        public ActionResult LogOut()
        {
            Session["user"] = null;
            return RedirectToAction("Index");
        }
  
	}
}