using KariyerNET.BLL.Abstract.CompanySide;
using KariyerNET.DAL.Abstract.CompanySide;
using KariyerNET.Model.CompanySide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Concrete.CompanySide
{
    public class SectorService : ISectorService
    {
        ISectorDAL _sectorDAL;

        public SectorService(ISectorDAL sectorDAL)
        {
            _sectorDAL = sectorDAL;
        }

        public void Delete(Sector entity)
        {
            _sectorDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _sectorDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Sector Get(int entityID)
        {
            return _sectorDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Sector> GetAll()
        {
            return _sectorDAL.GetAll();
        }

        public void Insert(Sector entity)
        {
            _sectorDAL.Add(entity);
        }

        public void Update(Sector entity)
        {
            _sectorDAL.Update(entity);
        }
    }
}
