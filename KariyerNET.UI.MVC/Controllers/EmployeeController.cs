using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KariyerNET.UI.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
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
            //Burası tamamlanacak.

            //try
            //{
            //    _companyService.Insert(company);
            //    //Eğer company içi doluysa kayıt tamamlnıp Viewe gitsin
            //    return View();
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Error = "Kayıt olma hatası!"; 
            //aynı kullanıcı ile giremezsin.
            //    return View();

            //}

            return RedirectToAction("","");
        }
    }
}