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
        public bool CreateInstrument()
        {
            throw new NotImplementedException();
        }

        public bool DeleteInstrument(int Id)
        {
            throw new NotImplementedException();
        }

        public Instruments GetInstrument(int InstrumentId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Instruments> GetInstruments()
        {
            throw new NotImplementedException();
        }

        public ICollection<Instruments> GetInstrumentsInLab()
        {
            throw new NotImplementedException();
        }

        public bool InstrumentExists(int Id)
        {
            throw new NotImplementedException();
        }

        public bool InstrumentExists(string name)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateInstrument(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
