﻿using KariyerNET.DAL.Abstract.EmployeeSide;
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
            _loginDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _loginDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Login Get(int entityID)
        {
            return _loginDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Login> GetAll()
        {
            return _loginDAL.GetAll();
        }

        public void Insert(Login entity)
        {
            _loginDAL.Add(entity);
        }

        public void Update(Login entity)
        {
            _loginDAL.Update(entity);
        }
    }
}
