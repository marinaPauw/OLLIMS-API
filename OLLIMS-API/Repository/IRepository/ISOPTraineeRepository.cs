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
        ICollection<SopTrainees> GetAllTraineesForSOP();
        SopTrainees GetSopTrainee(int SopTraineesId);

        bool SopTraineesExists(int Id);
        bool SopTraineesExists(string name);

        bool CreateSopTrainees();

        bool UpdateSopTrainees(int Id);
        bool DeleteSopTrainees(int Id);

        bool Save();

    }
}
