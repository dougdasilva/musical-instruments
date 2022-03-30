using MusicalInstruments.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstruments.Entities
{
    class Percussion : Instrument
    {
        public PercussionFamily PercussionType { get; set; }//percussão de pele ou efeito

        public Percussion()
        {
        }

        public Percussion(Classification instrumentType, string instrumentName, char clef, PercussionFamily percussionType)
            :base(instrumentType, instrumentName, clef)
        {
            PercussionType = percussionType;
        }
        public override string ToString()
        {
            return "Classification: "
                    + InstrumentType
                    + ", Name: "
                    + InstrumentName
                    + ", Clef: "
                    + Clef
                    + ", Percussion family: "
                    + PercussionType;
        }
    }
}
