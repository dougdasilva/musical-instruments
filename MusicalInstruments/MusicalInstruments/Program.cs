using System;
using MusicalInstruments.Entities;
using MusicalInstruments.Entities.Enums;

namespace MusicalInstruments
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Qual a classificação do seu instrumento (ChordStr, Wind or Percussion)? ");
                string s = Console.ReadLine();
                Classification classification;
                Enum.TryParse(s, out classification);

                if (s == "ChordStr")
                {
                    Console.Write("Nome do instrumento: ");
                    string name = Console.ReadLine();
                    Console.Write("Clave (F/G/C/P): "); // P = para clave de percussão
                    char clef = char.Parse(Console.ReadLine());
                    Console.Write("Número de cordas: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Modelo (Acoustic or Eletric): ");
                    string m = Console.ReadLine();
                    Model model;
                    Enum.TryParse(m, out model);

                    ChordStr str = new ChordStr(classification, name, clef, number, model);
                    Console.WriteLine(str.ToString());
                }
                else if (s == "Wind")
                {
                    Console.Write("Nome do instrumento: ");
                    string name = Console.ReadLine();
                    Console.Write("Clave (F/G/C/P): ");
                    char clef = char.Parse(Console.ReadLine());
                    Console.Write("Família (Wood or Metal): ");
                    string f = Console.ReadLine();
                    WindFamily windFamily;
                    Enum.TryParse(f, out windFamily);

                    Wind wind = new Wind(classification, name, clef, windFamily);
                    Console.WriteLine(wind.ToString());
                }
                else if (s == "Percussion")
                {
                    Console.Write("Nome do instrumento: ");
                    string name = Console.ReadLine();
                    Console.Write("Clave (F/G/C/P): ");
                    char clef = char.Parse(Console.ReadLine());
                    Console.Write("Família (Skin or Effects): ");
                    string p = Console.ReadLine();
                    PercussionFamily percussionFamily;
                    Enum.TryParse(p, out percussionFamily);

                    Percussion percussion = new Percussion(classification, name, clef, percussionFamily);
                    Console.WriteLine(percussion.ToString());
                }
                Console.WriteLine();
            } while (true);

    {

            }

        }
    }
}
