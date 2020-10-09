using OLLIMS_API.Models;
using OLLIMS_API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository
{
    public class MeasurementValueRepository : IMeasurementValueRepository
    {
        private readonly LIMSDbContext _db;

        public MeasurementValueRepository(LIMSDbContext db)
        {
            _db = db;
        }
        public bool CreateMeasurementValue(MeasurementValues value)
        {
            _db.MeasurementValues.Add(value);
            return Save();
        }

        public bool DeleteMeasurementValue(int Id)
        {
            _db.MeasurementValues.Remove(_db.MeasurementValues.FirstOrDefault(x => x.Id == Id));
            return Save();
        }

        public MeasurementValues GetMeasurementValue(int MeasurementValueId)
        {
            return _db.MeasurementValues.FirstOrDefault(x => x.Id == MeasurementValueId);
        }

        public ICollection<MeasurementValues> GetMeasurementValues()
        {
            return _db.MeasurementValues.OrderBy(x => x.Measurement).ToList();
        }

        public ICollection<MeasurementValues> GetMeasurementValuesForMeasurement(int measurementId)
        {
            return _db.MeasurementValues.Where(x => x.MeasurementId == measurementId).OrderBy(x => x.Id).ToList();
        }

        public bool MeasurementValueExists(int Id)
        {
            return _db.MeasurementValues.Any(x => x.Id == Id);
        }


        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateMeasurementValue(int Id)
        {
            _db.MeasurementValues.Update(_db.MeasurementValues.FirstOrDefault(x => x.Id == Id));
            return Save();
        }
    }
}
