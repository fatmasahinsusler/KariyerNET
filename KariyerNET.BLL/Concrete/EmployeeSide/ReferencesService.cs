using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class ReferencesService : IReferencesService
	{
        IReferencesDAL _referencesDAL;

        public ReferencesService(IReferencesDAL referencesDAL)
        {
            _referencesDAL = referencesDAL;
        }
        public void Delete(References entity)
        {
            _referencesDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _referencesDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public References Get(int entityID)
        {
            return _referencesDAL.Get(a => a.ID == entityID);
        }

        public ICollection<References> GetAll()
        {
            return _referencesDAL.GetAll();
        }

        public void Insert(References entity)
        {
            _referencesDAL.Add(entity);
        }

        public void Update(References entity)
        {
            _referencesDAL.Update(entity);
        }
    }
}
