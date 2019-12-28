using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class PerfectionService : IPerfectionService
	{
        IPerfectionDAL _perfectionDAL;

        public PerfectionService(IPerfectionDAL perfectionDAL)
        {
            _perfectionDAL = perfectionDAL;
        }
        public void Delete(Perfection entity)
        {
            _perfectionDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _perfectionDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Perfection Get(int entityID)
        {
            return _perfectionDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Perfection> GetAll()
        {
            return _perfectionDAL.GetAll();
        }

        public void Insert(Perfection entity)
        {
            _perfectionDAL.Add(entity);
        }

        public void Update(Perfection entity)
        {
            _perfectionDAL.Update(entity);
        }
    }
}
