using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface IMeasurementRepository
    {
        ICollection<Measurements> GetMeasurements();
        ICollection<Measurements> GetMeasurementsForInstrument();
        Measurements GetMeasurement(int MeasurementId);

        bool MeasurementExists(int Id);
        bool MeasurementExists(string name);

        bool CreateMeasurement();

        bool UpdateMeasurement(int Id);
        bool DeleteMeasurement(int Id);

        bool Save();

    }
}
