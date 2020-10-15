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
        public bool CreateSop(InstrumentSOP sop)
        {
            _db.InstrumentSOP.Add(sop);
            return Save();
        }

        public bool DeleteSop(int Id)
        {
            _db.InstrumentSOP.Remove(_db.InstrumentSOP.FirstOrDefault(x => x.Id == Id));
            return Save();
        }

        public InstrumentSOP GetSop(int Id)
        {
            return _db.InstrumentSOP.FirstOrDefault(x => x.Id == Id);
        }

        public ICollection<InstrumentSOP> GetSops()
        {
            return _db.InstrumentSOP.OrderBy(x => x.Id).ToList();
        }

        public ICollection<InstrumentSOP> GetSopsForInstrument(int Id)
        {
            return _db.InstrumentSOP.Where(x => x.Id == Id).OrderBy(x => x.Id).ToList();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool SopExists(int Id)
        {
            return _db.InstrumentSOP.Any(x => x.Id == Id);
        }

        public bool SopExists(string name)
        {
            return _db.InstrumentSOP.Any(x => x.Name.ToLower().Trim() == name.ToLower().Trim());
        }

        public bool UpdateSop(int Id)
        {
            _db.InstrumentSOP.Update(_db.InstrumentSOP.FirstOrDefault(x => x.Id == Id));
            return Save();
        }
    }
}
