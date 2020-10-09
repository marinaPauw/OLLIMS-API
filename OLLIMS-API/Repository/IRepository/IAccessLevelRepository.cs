using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface IAccessLevelsRepository
    {
        ICollection<AccessLevel> GetAccessLevels();
        AccessLevel GetAccessLevel(int AccessLevelsId);

        bool AccessLevelsExists(int Id);
        bool AccessLevelsExists(string name);

        bool CreateAccessLevels(AccessLevel al);

        bool UpdateAccessLevels(int Id);
        bool DeleteAccessLevels(int Id);

        bool Save();

    }
}
