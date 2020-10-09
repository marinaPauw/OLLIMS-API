using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface ISopTraineesRepository
    {
        ICollection<SopTrainees> GetSopTrainees();
        ICollection<Personel> GetAllTraineesForSOP(int Id);
        SopTrainees GetSopTrainee(int SopTraineesId);

        bool SopTraineesExists(int Id);

        bool CreateSopTrainees(SopTrainees st);

        bool UpdateSopTrainees(int Id);
        bool DeleteSopTrainees(int Id);

        bool Save();

    }
}
