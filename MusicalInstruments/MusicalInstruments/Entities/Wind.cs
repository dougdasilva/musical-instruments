using MusicalInstruments.Entities.Enums;

namespace MusicalInstruments.Entities
{
    class Wind : Instrument
    {
        public WindFamily WindType { get; set; }//tipo de instrumento de sopro: madeira ou metal.
        public Wind()
        {

        }

        public Wind(Classification instrumentType, string instrumentName, char clef, WindFamily windType)
            :base(instrumentType, instrumentName, clef)
        {
            WindType = windType;
        }
        public override string ToString()
        {
            return "Classification: "
                    + InstrumentType
                    + ", Name: "
                    + InstrumentName
                    + ", Clef: "
                    + Clef
                    + ", Wind family: "
                    + WindType;
        }
    }
}
