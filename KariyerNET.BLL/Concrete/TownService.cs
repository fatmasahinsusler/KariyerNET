using KariyerNET.DAL.Abstract;
using KariyerNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract
{
	public class TownService : ITownService
	{
        ITownDAL _townDAL;

        public TownService(ITownDAL townDAL)
        {
            _townDAL = townDAL;
        }
        public void Delete(Town entity)
        {
            _townDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _townDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Town Get(int entityID)
        {
            return _townDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Town> GetAll()
        {
            return _townDAL.GetAll();
        }

        public void Insert(Town entity)
        {
            _townDAL.Add(entity);
        }

        public void Update(Town entity)
        {
            _townDAL.Update(entity);
        }
    }
}
