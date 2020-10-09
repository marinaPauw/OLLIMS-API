using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface ISopRepository
    {
        ICollection<Sop> GetSops();
        ICollection<Sop> GetSopsForInstrument();
        Sop GetSop(int SopId);

        bool SopExists(int Id);
        bool SopExists(string name);

        bool CreateSop(Sop sop);

        bool UpdateSop(int Id);
        bool DeleteSop(int Id);

        bool Save();

    }
}
