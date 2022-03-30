using MusicalInstruments.Entities.Enums;

namespace MusicalInstruments.Entities
{
    class ChordStr : Instrument
    {
        public int NumberOfStrings { get; set; }//número de cordas
        public Model Model { get; set; }//modelo acústico ou elétrico

        public ChordStr()
        {

        }

        public ChordStr(Classification instrumentType, string instrumentName, char clef, int numberOfStrings, Model model)
                        :base(instrumentType, instrumentName, clef)
        {
            NumberOfStrings = numberOfStrings;
            Model = model;
        }
        public override string ToString()
        {
            return "Classification: "
                    + InstrumentType
                    + ", Name: "
                    + InstrumentName
                    + ", Clef: "
                    + Clef
                    + ", Número de cordas: "
                    + NumberOfStrings
                    + ", Modelo: "
                    + Model;
        }
    }
}
