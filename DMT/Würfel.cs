using System;
using System.Collections.Generic;

namespace DMT
{
    public class Würfel : IWürfel
    {
        public int Würfeln(int würfelTyp, bool vorteil, bool nachteil)
        {
            if(vorteil && nachteil)
            {
                vorteil = nachteil = false;
            }

            var numbers = new List<int>();
            Random rNumber = new Random();
            int number = -1;

            int würfelAnzahl = 1;
            if (vorteil || nachteil)
            {
                würfelAnzahl = 2;
            }

            for (int i = 0; i < würfelAnzahl; i++)
            {
                numbers.Add(rNumber.Next(1, würfelTyp));
            }

            numbers.Sort();

            if (nachteil)
            {                
                number = numbers[0];
            }
            else
            {
                number = numbers[1];
            }

            return number;
        }
    }
}
