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
			throw new NotImplementedException();
		}

		public void DeleteById(int entityID)
		{
			throw new NotImplementedException();
		}

		public Language Get(int entityID)
		{
			throw new NotImplementedException();
		}

		public ICollection<Language> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Language entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Language entity)
		{
			throw new NotImplementedException();
		}
	}
}
