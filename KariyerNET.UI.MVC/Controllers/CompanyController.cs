using KariyerNET.BLL.Abstract.CompanySide;
using KariyerNET.Model.CompanySide;
using KariyerNET.UI.MVC.CustomFilter;
using KariyerNET.UI.MVC.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KariyerNET.UI.MVC.Controllers
{
    public class CompanyController : Controller
    {
        ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[CustomFilter()]
        public ActionResult Login(Company company)
        {
            var gelenKullanici = _companyService.CompanyLogin(company.EMail,company.Password);
            if (gelenKullanici != null)
            {
                Session["user"] = gelenKullanici;
                return RedirectToAction("Index", "Home"); //babanın evine git:D
            }
            
            else
            {
                ViewBag.Error = "Kullanıcı Bulunamadı, Lütfen Üye Olunuz!";
                return View();
            }
           
        }

        [HttpGet]
        public ActionResult Register()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Company company)
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
            //    return View();

            //}
            ViewBag.Message = "Kayıt oluşturuldu";
            return RedirectToAction("Login", "Company");
        }

        [HttpGet]
        public ActionResult ForgetPassword()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult ForgetPassword(int companyID)
        //{            
        // 
        //Bu sayfa açılırken kullanıcı ID'sini view'den alması lazım yada maile göre Id getiren bir metod yazıcaz bll'de. Halledicez koçlarr 

        //    var kullanici = _companyService.Get(companyID);

        //    bool sonuc = MailHelper.SendConfirmationMail(kullanici.EMail,kullanici.CompanyName,kullanici.Password);
        //    if (!sonuc)
        //    {
        //        ViewBag.Error = "Mail gönderilemedi, daha sonra tekrar deneyiniz.";
        //        return View();
        //    }
        //    return View();
        //}
        
    }
}