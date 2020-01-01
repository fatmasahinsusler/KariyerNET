using KariyerNET.BLL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KariyerNET.UI.MVC.Controllers
{
    public class JobAdvertController : Controller
    {
        ILoginService _loginService;

        public JobAdvertController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        // GET: JobAdvert
        public ActionResult Index()
        {
            
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(Login login)
        //{

        //    var gelenKullanici = _loginService.GetUser(login.LoginMail, login.Password);
        //    if (gelenKullanici != null)
        //    {
        //        Session["user"] = gelenKullanici;
        //        return RedirectToAction("BeforeApply","JobAdvert");
        //    }
        //    ViewBag.Error = "Giriş yapınız!";            
        //    return View("Register", "Employee");


        //}
        public ActionResult BeforeApply(Login login)
        {
            var gelenKullanici = _loginService.GetUser(login.LoginMail, login.Password); 
            if (gelenKullanici != null)
            {
                Session["user"] = gelenKullanici;
                return RedirectToAction("BeforeApply", "JobAdvert");
            }
            ViewBag.Error = "Giriş yapınız!";
            return RedirectToAction("Login", "Employee");
        }
    }
}