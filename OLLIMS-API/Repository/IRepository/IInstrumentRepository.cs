using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface IInstrumentRepository
    {
        ICollection<Instruments> GetInstruments();
        ICollection<Instruments> GetInstrumentsInLab();
        Instruments GetInstrument(int InstrumentId);

        bool InstrumentExists(int Id);
        bool InstrumentExists(string name);

        bool CreateInstrument();

        bool UpdateInstrument(int Id);
        bool DeleteInstrument(int Id);

        bool Save();

    }
}
