using OLLIMS_API.Models;
using OLLIMS_API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository
{
    public class AccessLevelRepository : IAccessLevelsRepository
    {
        public bool AccessLevelsExists(int Id)
        {
            throw new NotImplementedException();
        }

        public bool AccessLevelsExists(string name)
        {
            throw new NotImplementedException();
        }

        public bool CreateAccessLevels()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAccessLevels(int Id)
        {
            throw new NotImplementedException();
        }

        public AccessLevels GetAccessLevel(int AccessLevelsId)
        {
            throw new NotImplementedException();
        }

        public ICollection<AccessLevels> GetAccessLevels()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateAccessLevels(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
