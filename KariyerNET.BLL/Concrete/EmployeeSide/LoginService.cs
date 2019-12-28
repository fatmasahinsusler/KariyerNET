using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class LoginService : ILoginService
	{
        ILoginDAL _loginDAL;

        public LoginService(ILoginDAL loginDAL)
        {
            _loginDAL = loginDAL;
        }
		public void Delete(Login entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Login Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Login> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Login entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Login entity)
		{
			throw new NotImplementedException();
		}
	}
}
