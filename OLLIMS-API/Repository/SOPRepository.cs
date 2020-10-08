using OLLIMS_API.Models;
using OLLIMS_API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository
{
    public class SOPRepository : ISopRepository
    {
        public bool CreateSop()
        {
            throw new NotImplementedException();
        }

        public bool DeleteSop(int Id)
        {
            throw new NotImplementedException();
        }

        public Sop GetSop(int SopId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Sop> GetSops()
        {
            throw new NotImplementedException();
        }

        public ICollection<Sop> GetSopsForInstrument()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool SopExists(int Id)
        {
            throw new NotImplementedException();
        }

        public bool SopExists(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSop(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
