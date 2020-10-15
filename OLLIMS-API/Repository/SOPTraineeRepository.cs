using OLLIMS_API.Models;
using OLLIMS_API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository
{
    public class SOPTraineeRepository : ISOPTraineeRepository
    {
        private readonly LIMSDbContext _db;

        public SOPTraineeRepository(LIMSDbContext db)
        {
            _db = db;
        }
        public bool CreateSOPTrainees(SOPTrainee st)
        {
            _db.SopTrainees.Add(st);
            return Save();
        }

        public bool DeleteSOPTrainees(int Id)
        {
            _db.SopTrainees.Remove(_db.SopTrainees.FirstOrDefault(x => x.Id == Id));
            return Save();
        }

        public ICollection<Employee> GetAllTraineesForSOP(int Id)
        {
            return _db.SopTrainees.Where(x => x.SOP.Id == Id).OrderBy(x => x.SOP).Select(x=>x.Employee).ToList();
        }

        public SOPTrainee GetSOPTrainee(int Id)
        {
            return _db.SopTrainees.FirstOrDefault(x => x.Id == Id);
        }

        public ICollection<SOPTrainee> GetSOPTrainees()
        {
            return _db.SopTrainees.OrderBy(x => x.Id).ToList();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool SOPTraineesExists(int Id)
        {
            return _db.SopTrainees.Any(x => x.Id == Id);
        }

        

        public bool UpdateSOPTrainees(int Id)
        {
            _db.SopTrainees.Update(_db.SopTrainees.FirstOrDefault(x => x.Id == Id));
            return Save();
        }
    }
}
