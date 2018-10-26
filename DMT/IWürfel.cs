using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMT
{
    interface IWürfel
    {
        int Würfeln(int würfelTyp, bool vorteil, bool nachteil);
    }
}
