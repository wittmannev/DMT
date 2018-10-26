using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContract
{
    class Dices
        {
            DiceTypes DiceType { get; set; }

            public Dices(DiceTypes diceType)
            {
                DiceType = diceType;
            }

            public enum DiceTypes { Dreier = 3, Vierer = 4, Sechser = 6, Achter = 8, Zehner = 10, Zwölfer = 12, Zwanziger = 20, Hunderter = 100 }

       
        }
}
