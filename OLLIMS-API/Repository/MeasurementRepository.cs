using OLLIMS_API.Models;
using OLLIMS_API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository
{

    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly LIMSDbContext _db;

        public MeasurementRepository(LIMSDbContext db)
        {
            _db = db;
        }
        public bool CreateMeasurement(Measurements measurement)
        {
            _db.Measurements.Add(measurement);
            return Save();
        }

        public bool DeleteMeasurement(int Id)
        {
            _db.Measurements.Remove(_db.Measurements.FirstOrDefault(x => x.Id == Id));
            return Save();
        }

        public Measurements GetMeasurement(int Id)
        {
            return _db.Measurements.FirstOrDefault(x => x.Id == Id);
        }

        public ICollection<Measurements> GetMeasurements()
        {
            return _db.Measurements.OrderBy(x => x.Name).ToList();
        }

        public ICollection<Measurements> GetMeasurementsForInstrument(int Id)
        {
            return _db.Measurements.Where(x => x.InstrumentId == Id).OrderBy(x => x.Id).ToList();
        }

        public bool MeasurementExists(int Id)
        {
            return _db.Measurements.Any(x => x.Id == Id);
        }

        public bool MeasurementExists(string name)
        {
            return _db.Measurements.Any(x => x.Name.ToLower().Trim() == name.ToLower().Trim());
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateMeasurement(int Id)
        {
            _db.Measurements.Update(_db.Measurements.FirstOrDefault(x => x.Id == Id));
            return Save();
        }
    }
}
