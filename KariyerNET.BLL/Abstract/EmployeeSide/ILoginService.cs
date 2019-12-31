﻿using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public interface ILoginService: IBaseService<Login>
	{

         Login GetLogin(string loginMail);//şifremi unuttum kısmı için

        Login GetUser(string mail, string password); //session için mail ve sifre lazımmm

    }
}
