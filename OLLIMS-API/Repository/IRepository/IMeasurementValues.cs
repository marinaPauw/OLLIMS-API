using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface IMeasurementValueRepository
    {
        ICollection<MeasurementValues> GetMeasurementValues();
        ICollection<MeasurementValues> GetMeasurementValuesForMeasurement();
        MeasurementValues GetMeasurementValue(int MeasurementValueId);

        bool MeasurementValueExists(int Id);
        bool MeasurementValueExists(string name);

        bool CreateMeasurementValue();

        bool UpdateMeasurementValue(int Id);
        bool DeleteMeasurementValue(int Id);

        bool Save();

    }
}

