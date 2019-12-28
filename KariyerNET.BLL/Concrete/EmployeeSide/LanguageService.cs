using KariyerNET.DAL.Abstract.EmployeeSide;
using KariyerNET.Model.EmployeeSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNET.BLL.Abstract.EmployeeSide
{
	public class LanguageService : ILanguageService
	{
        ILanguageDAL _languageDAL;

        public LanguageService(ILanguageDAL languageDAL)
        {
            _languageDAL = languageDAL;
        }
        public void Delete(Language entity)
        {
            _languageDAL.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var entity = _languageDAL.Get(a => a.ID == entityID);
            Delete(entity);
        }

        public Language Get(int entityID)
        {
            return _languageDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Language> GetAll()
        {
            return _languageDAL.GetAll();
        }

        public void Insert(Language entity)
        {
            _languageDAL.Add(entity);
        }

        public void Update(Language entity)
        {
            _languageDAL.Update(entity);
        }
    }
}
