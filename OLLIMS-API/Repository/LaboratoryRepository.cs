using OLLIMS_API.Models;
using OLLIMS_API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository
{
    public class LaboratoryRepository : ILaboratoryRepository
    {
        private readonly LIMSDbContext _db;
        public LaboratoryRepository(LIMSDbContext db)
        {
            _db = db;
        }
        public bool CreateLaboratory(Laboratory laboratory)
        {
            _db.Laboratories.Add(laboratory);
            return Save();
        }

        public bool DeleteLaboratory(int Id)
        {
            _db.Laboratories.Remove(_db.Laboratories.FirstOrDefault(x => x.Id == Id));
            return Save();
        }

        public ICollection<Laboratory> GetLaboratories()
        {
            return _db.Laboratories.OrderBy(x=>x.LaboratoryName).ToList();
        }

        public Laboratory GetLaboratory(int laboratoryId)
        {
            return _db.Laboratories.FirstOrDefault(x => x.Id == laboratoryId);
        }

        public bool LaboratoryExists(int Id)
        {

            return _db.Laboratories.Any(x => x.Id == Id);
        }

        public bool LaboratoryExists(string name)
        {
            return _db.Laboratories.Any(x => x.LaboratoryName.ToLower().Trim() == name.ToLower().Trim());
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateLaboratory(int Id)
        {
            _db.Laboratories.Update(_db.Laboratories.FirstOrDefault(x => x.Id == Id));
            return Save();
        }
    }
}
