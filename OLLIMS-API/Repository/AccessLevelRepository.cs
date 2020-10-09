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
        private readonly LIMSDbContext _db;

        public AccessLevelRepository(LIMSDbContext db)
        {
            _db = db;
        }
        public bool AccessLevelsExists(int Id)
        {
            return _db.AccessLevels.Any(x => x.Id == Id);
        }

        public bool AccessLevelsExists(string name)
        {
            return _db.AccessLevels.Any(x => x.Name == name);
        }

        public bool CreateAccessLevels(AccessLevels al)
        {
            _db.AccessLevels.Add(al);
            return Save();
        }

        public bool DeleteAccessLevels(int Id)
        {
            _db.AccessLevels.Remove(_db.AccessLevels.FirstOrDefault(x => x.Id == Id));
            return Save();
        }

        public AccessLevels GetAccessLevel(int AccessLevelsId)
        {
            return _db.AccessLevels.FirstOrDefault(x => x.Id == AccessLevelsId);
        }

        public ICollection<AccessLevels> GetAccessLevels()
        {
            return _db.AccessLevels.OrderBy(x => x.Name).ToList();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateAccessLevels(int Id)
        {
            _db.AccessLevels.Update(_db.AccessLevels.FirstOrDefault(x => x.Id == Id));
            return Save();
        }
    }
}
