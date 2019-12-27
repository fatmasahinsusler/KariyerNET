using KariyerNET.BLL.Abstract.Firma;
using KariyerNET.DAL.Abstract.Firma;
using KariyerNET.Model.Firma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Concrete.Firma
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
            throw new NotImplementedException();
        }

        public void DeleteById(int entityID)
        {
            throw new NotImplementedException();
        }

        public Sector Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Sector> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Sector entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Sector entity)
        {
            throw new NotImplementedException();
        }
    }
}
