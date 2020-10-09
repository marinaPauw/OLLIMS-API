using AutoMapper;
using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Mappings
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            CreateMap<Laboratory, LaboratoryDTO>().ReverseMap();
            CreateMap<AccessLevel, AccessLevelDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Instrument, InstrumentDTO>().ReverseMap();
            CreateMap<Measurement, MeasurementDTO>().ReverseMap();
            CreateMap<MeasurementValue, MeasurementValueDTO>().ReverseMap();
            CreateMap<Sop, SOPDTO>().ReverseMap();
            CreateMap<SopTrainee, SopTraineeDTO>().ReverseMap();
        }
    }
}
