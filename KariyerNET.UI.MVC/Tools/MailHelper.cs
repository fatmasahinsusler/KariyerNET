using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace KariyerNET.UI.MVC.Tools
{
    public class MailHelper
    {
        public static bool SendForgottenPasswordMail(string toAddress, string username, string forgettingPassword)
        {
            /*
             * noreply.hrdanismanlik@gmail.com hayırlı olsun askolar 
             * Burada bizim NoReply hesabımızdan kullanıcı emailine, passwordüsü (ForeignKeysi :D:D ) gidiyor.
             * 
            */

            bool result = false;
            MailMessage msg = new MailMessage(); //msg adında MailMessage nesnesi oluşturduk.

            msg.From = new MailAddress("noreply.hrdanismanlik@gmail.com"); //Kimden gidiyor, bizden gidiyor

            msg.To.Add(toAddress); //Kime gidiyor, parametreden gelen kullanıcının mailine

            msg.Subject = "HR DANISMANLIK | Parola Hatırlatma Servisi"; //mail konusu

            msg.IsBodyHtml = true; //Mail içeriğinde html kodu olsunmu, yess.

            msg.Body = "Merhaba " + "<b>" + username + "</b>" + " bu bir şifre hatırlatma mailidir.<br><br>Şifreniz: " + "<b>" + forgettingPassword + "</b>"; //Mail içeriğimiz...

            SmtpClient smptClient = new SmtpClient("smtp.gmail.com", 587); //bunlar mail gönderme ayarları tam bilmiyom copy+paste
            smptClient.EnableSsl = true;//aynısı

            NetworkCredential credential = new NetworkCredential(msg.From.Address, "askoyazilim1*"); //Burda hr danısmanlık mail adresini ve şifresini veriyoruz ki hesaba girip mail atabilsin. Yetki veriyoruz bir nevi.

            smptClient.Credentials = credential; //ıvır zıvır copy paste
            try
            {
                smptClient.Send(msg); //Mail gönderilirse resultumuzu trueya çekiyoruz, metoddan bool değer döncek
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;

        }

        public static bool SendConfirmationMail(string toAddress, string username)
        {

            bool result = false;
            MailMessage msg = new MailMessage(); //msg adında MailMessage nesnesi oluşturduk.

            msg.From = new MailAddress("noreply.hrdanismanlik@gmail.com"); //Kimden gidiyor, bizden gidiyor

            msg.To.Add(toAddress); //Kime gidiyor, parametreden gelen kullanıcının mailine

            msg.Subject = "HR DANISMANLIK | Aramıza hoş geldiniz"; //mail konusu

            msg.IsBodyHtml = true; //Mail içeriğinde html kodu olsunmu, yess.

            msg.Body = "Merhaba " + "<b>" + username + "</b>" + ".<br>Üyeliğiniz başarıyla oluşturuldu."; //Mail içeriğimiz...

            SmtpClient smptClient = new SmtpClient("smtp.gmail.com", 587); //bunlar mail gönderme ayarları tam bilmiyom copy+paste
            smptClient.EnableSsl = true;//aynısı

            NetworkCredential credential = new NetworkCredential(msg.From.Address, "askoyazilim1*"); //Burda hr danısmanlık mail adresini ve şifresini veriyoruz ki hesaba girip mail atabilsin. Yetki veriyoruz bir nevi.

            smptClient.Credentials = credential; //ıvır zıvır copy paste
            try
            {
                smptClient.Send(msg); //Mail gönderilirse resultumuzu trueya çekiyoruz, metoddan bool değer döncek
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;

        }


    }
}