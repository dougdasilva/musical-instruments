using MusicalInstruments.Entities.Enums;

namespace MusicalInstruments.Entities
{
    class Instrument
    {
        public Classification InstrumentType { get; set; }//classificação do instrumento(cordas, sopro ou percussão)
        public string InstrumentName { get; set; }//nome do instrumento(Ex: violão)
        public char Clef { get; set; }//clave (Ex: F (Fá) ou G (Sol)

        public Instrument()
        {

        }
        public Instrument(Classification instrumentType, string instrumentName, char clef)
        {
           
            InstrumentType = instrumentType;
            InstrumentName = instrumentName;
            Clef = clef;
        }
    }
}
