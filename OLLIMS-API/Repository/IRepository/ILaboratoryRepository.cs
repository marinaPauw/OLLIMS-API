using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface ILaboratoryRepository
    {
        ICollection<Laboratories> GetLaboratories();
        Laboratories GetLaboratory(int LaboratoryId);

        bool LaboratoryExists(int Id);
        bool LaboratoryExists(string name);

        bool CreateLaboratory();

        bool UpdateLaboratory(int Id);
        bool DeleteLaboratory(int Id);

        bool Save()

    }
}
