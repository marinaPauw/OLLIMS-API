using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface IPersonelRepository
    {
        ICollection<Personel> GetPersonel();
        Personel GetPerson(int PersonelId);

        bool PersonelExists(int Id);
        bool PersonelExists(string name);

        bool CreatePersonel();

        bool UpdatePersonel(int Id);
        bool DeletePersonel(int Id);

        bool Save();

    }
}
