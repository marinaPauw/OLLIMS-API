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
        public bool CreateMeasurement()
        {
            throw new NotImplementedException();
        }

        public bool DeleteMeasurement(int Id)
        {
            throw new NotImplementedException();
        }

        public Measurements GetMeasurement(int MeasurementId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Measurements> GetMeasurements()
        {
            throw new NotImplementedException();
        }

        public ICollection<Measurements> GetMeasurementsForInstrument()
        {
            throw new NotImplementedException();
        }

        public bool MeasurementExists(int Id)
        {
            throw new NotImplementedException();
        }

        public bool MeasurementExists(string name)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateMeasurement(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
