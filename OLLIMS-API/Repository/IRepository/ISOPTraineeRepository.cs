using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface ISOPTraineeRepository
    {
        ICollection<SOPTrainee> GetSOPTrainees();
        ICollection<Employee> GetAllTraineesForSOP(int Id);
        SOPTrainee GetSOPTrainee(int SOPTraineesId);

        bool SOPTraineesExists(int Id);

        bool CreateSOPTrainees(SOPTrainee st);

        bool UpdateSOPTrainees(int Id);
        bool DeleteSOPTrainees(int Id);

        bool Save();

    }
}
