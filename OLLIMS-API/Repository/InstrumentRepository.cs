using OLLIMS_API.Models;
using OLLIMS_API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository
{

    public class InstrumentRepository : IInstrumentRepository
    {
        private readonly LIMSDbContext _db;

        public InstrumentRepository(LIMSDbContext db)
        {
            _db = db;
        }
        public bool CreateInstrument(Instrument instrument)
        {
            _db.Instruments.Add(instrument);
            return Save();
        }

        public bool DeleteInstrument(int Id)
        {
            _db.Instruments.Remove(_db.Instruments.FirstOrDefault(x => x.Id == Id));
            return Save();
        }

        public Instrument GetInstrument(int InstrumentId)
        {
            return _db.Instruments.FirstOrDefault(x => x.Id == InstrumentId);
        }

        public ICollection<Instrument> GetInstruments()
        {
            return _db.Instruments.OrderBy(x => x.Id).ToList();
        }

        public ICollection<Instrument> GetInstrumentsInLab(int Id)
        {
            return _db.Instruments.Where(x=>x.LaboratoryId==Id).OrderBy(x => x.Id).ToList();
        }

        public bool InstrumentExists(int Id)
        {
            return _db.Instruments.Any(x => x.Id == Id);
        }


        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateInstrument(int Id)
        {
            _db.Instruments.Update(_db.Instruments.FirstOrDefault(x => x.Id == Id));
            return Save();
        }
    }
}
