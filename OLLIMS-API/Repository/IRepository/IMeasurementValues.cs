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
        ICollection<MeasurementValues> GetMeasurementValuesForMeasurement(int measurementId);
        MeasurementValues GetMeasurementValue(int MeasurementValueId);

        bool MeasurementValueExists(int Id);

        bool CreateMeasurementValue(MeasurementValues value);

        bool UpdateMeasurementValue(int Id);
        bool DeleteMeasurementValue(int Id);

        bool Save();

    }
}

