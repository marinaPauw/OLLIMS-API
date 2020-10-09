using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface ISopTraineesRepository
    {
        ICollection<SopTrainee> GetSopTrainees();
        ICollection<Employee> GetAllTraineesForSOP(int Id);
        SopTrainee GetSopTrainee(int SopTraineesId);

        bool SopTraineesExists(int Id);

        bool CreateSopTrainees(SopTrainee st);

        bool UpdateSopTrainees(int Id);
        bool DeleteSopTrainees(int Id);

        bool Save();

    }
}
