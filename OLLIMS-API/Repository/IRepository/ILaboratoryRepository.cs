using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface ILaboratoryRepository
    {
        ICollection<Laboratory> GetLaboratories();
        Laboratory GetLaboratory(int LaboratoryId);

        bool LaboratoryExists(int Id);
        bool LaboratoryExists(string name);

        bool CreateLaboratory(Laboratory laboratory);

        bool UpdateLaboratory(int Id);
        bool DeleteLaboratory(int Id);

        bool Save();

    }
}
