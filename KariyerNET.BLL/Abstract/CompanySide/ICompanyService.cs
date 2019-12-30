using KariyerNET.Model.CompanySide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.CompanySide
{
	public interface ICompanyService : IBaseService<Company>
	{
		Company CompanyLogin(string mail, string password);
	}
}
