using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class HobbieService : IHobbieService
	{
        IHobbieDAL _hobbieDAL;
        public HobbieService(IHobbieDAL hobbieDAL)
        {
            _hobbieDAL = hobbieDAL;
        }
		public void Delete(Hobbie entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Hobbie Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Hobbie> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Hobbie entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Hobbie entity)
		{
			throw new NotImplementedException();
		}
	}
}
