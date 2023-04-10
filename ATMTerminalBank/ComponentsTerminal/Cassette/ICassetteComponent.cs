using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.ComponentsTerminal.Cassette
{
    // ИНТЕРФЕЙС КОМПОНЕНТА КАССЕТЫ 
    interface ICassetteComponent
    {
        bool GiveMoney(int money);
        bool ReceiveMoney(int money);
    }
}
