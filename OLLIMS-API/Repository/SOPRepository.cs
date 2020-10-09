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
        private readonly LIMSDbContext _db;

        public SOPRepository(LIMSDbContext db)
        {
            _db = db;
        }
        public bool CreateSop(Sop sop)
        {
            _db.Sop.Add(sop);
            return Save();
        }

        public bool DeleteSop(int Id)
        {
            _db.Sop.Remove(_db.Sop.FirstOrDefault(x => x.Id == Id));
            return Save();
        }

        public Sop GetSop(int Id)
        {
            return _db.Sop.FirstOrDefault(x => x.Id == Id);
        }

        public ICollection<Sop> GetSops()
        {
            return _db.Sop.OrderBy(x => x.Id).ToList();
        }

        public ICollection<Sop> GetSopsForInstrument(int Id)
        {
            return _db.Sop.Where(x => x.Id == Id).OrderBy(x => x.Id).ToList();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool SopExists(int Id)
        {
            return _db.Sop.Any(x => x.Id == Id);
        }

        public bool SopExists(string name)
        {
            return _db.Sop.Any(x => x.Name.ToLower().Trim() == name.ToLower().Trim());
        }

        public bool UpdateSop(int Id)
        {
            _db.Sop.Update(_db.Sop.FirstOrDefault(x => x.Id == Id));
            return Save();
        }
    }
}
