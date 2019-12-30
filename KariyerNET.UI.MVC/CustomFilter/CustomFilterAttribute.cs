using KariyerNET.BLL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KariyerNET.UI.MVC.CustomFilter
{
    public class CustomFilterAttribute : ActionFilterAttribute
    {
        //public string LoginMail { get; set; }
        //public string Password { get; set; }

        //public CustomFilterAttribute(string mail,string password)
        //{
        //    LoginMail = mail;
        //    Password = password;
        //}

            //CustomFilter'in bir parametre almasına gerek yok. Metodu direkt calıstırır. Hocaya soruldu :)
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Login user = null;
            if (filterContext.HttpContext.Session["user"] != null)
            {
               user= filterContext.HttpContext.Session["user"] as Login;
            }
            else
            {
                filterContext.Result = new RedirectResult("/Home/Index");// login sayfasını yaz gitsin.
            }
        }
    }
}