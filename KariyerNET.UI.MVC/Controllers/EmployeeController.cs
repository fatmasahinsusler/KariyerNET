using KariyerNET.BLL.Abstract.EmployeeSide;
using KariyerNET.BLL.Concrete.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using KariyerNET.UI.MVC.CustomFilter;
using KariyerNET.UI.MVC.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KariyerNET.UI.MVC.Controllers
{
    public class EmployeeController : Controller
    {
    
        ILoginService _loginService;
        public EmployeeController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [IsLoginFilter()]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]      
        public ActionResult Login(Login login)
        {
            var gelenKullanici = _loginService.GetUser(login.LoginMail, login.Password);
            if (gelenKullanici != null)
            {
                Session["user"] = gelenKullanici;
                return RedirectToAction("Index", "Home"); 
            }
            ViewBag.Error = "Kullanıcı Bulunamadı, Lütfen Üye Olunuz!";
            return View();

        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Login user)
        {
            try
            {
                _loginService.Insert(user);
                ViewBag.Message = "Kayıt oluşturuldu";
                return RedirectToAction("Login", "Employee");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
            
        }


        [HttpGet]
        public ActionResult ForgetPassword()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ForgetPassword(string mail)
        {
            Login kullanici = null;
            if (_loginService.GetLogin(mail) == null)
            {
                ViewBag.Error = "Mail adresi kayıtlı değil!";
                return View();
            }
            kullanici= _loginService.GetLogin(mail);
            MailHelper.SendConfirmationMail(kullanici.LoginMail, kullanici.FirstName + " " + kullanici.SurName, kullanici.Password);   
            return RedirectToAction("Login","Employee");
        }


    }
}