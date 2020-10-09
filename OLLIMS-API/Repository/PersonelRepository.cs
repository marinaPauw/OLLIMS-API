using OLLIMS_API.Models;
using OLLIMS_API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository
{
    public class PersonelRepository : IPersonelRepository
    {
        private readonly LIMSDbContext _db;

        public PersonelRepository(LIMSDbContext db)
        {
            _db = db;
        }
        public bool CreatePersonel(Sop sop)
        {
            _db.Sop.Add(sop);
            return Save();
        }

        public bool DeletePersonel(int Id)
        {
            _db.Personel.Remove(_db.Personel.FirstOrDefault(x => x.Id == Id));
            return Save();
        }

        public Personel GetPerson(int Id)
        {
            return _db.Personel.FirstOrDefault(x => x.Id == Id);
        }

        public ICollection<Personel> GetPersonel()
        {
            return _db.Personel.OrderBy(x => x.Id).ToList();
        }

        public bool PersonelExists(int Id)
        {
            return _db.Personel.Any(x => x.Id == Id);
        }

       
        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdatePersonel(int Id)
        {
            _db.Personel.Update(_db.Personel.FirstOrDefault(x => x.Id == Id));
            return Save();
        }
    }
}
