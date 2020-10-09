using OLLIMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLLIMS_API.Repository.IRepository
{
    public interface IInstrumentRepository
    {
        ICollection<Instrument> GetInstruments();
        ICollection<Instrument> GetInstrumentsInLab(int Id);
        Instrument GetInstrument(int InstrumentId);

        bool InstrumentExists(int Id);

        bool CreateInstrument(Instrument instrument);

        bool UpdateInstrument(int Id);
        bool DeleteInstrument(int Id);

        bool Save();

    }
}
