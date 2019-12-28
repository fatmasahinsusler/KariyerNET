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
            _hobbieDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _hobbieDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Hobbie Get(int entityID)
        {
            return _hobbieDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Hobbie> GetAll()
        {
            return _hobbieDAL.GetAll();
        }

        public void Insert(Hobbie entity)
        {
            _hobbieDAL.Add(entity);
        }

        public void Update(Hobbie entity)
        {
            _hobbieDAL.Update(entity);
        }
    }
}
