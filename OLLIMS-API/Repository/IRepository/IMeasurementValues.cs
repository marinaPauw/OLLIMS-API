using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface IMeasurementValueRepository
    {
        ICollection<MeasurementValue> GetMeasurementValues();
        ICollection<MeasurementValue> GetMeasurementValuesForMeasurement(int measurementId);
        MeasurementValue GetMeasurementValue(int MeasurementValueId);

        bool MeasurementValueExists(int Id);

        bool CreateMeasurementValue(MeasurementValue value);

        bool UpdateMeasurementValue(int Id);
        bool DeleteMeasurementValue(int Id);

        bool Save();

    }
}

