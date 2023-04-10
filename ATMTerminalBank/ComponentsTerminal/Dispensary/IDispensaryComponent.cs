using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.ComponentsTerminal.Dispensary
{
    // ИНТЕРФЕЙС КОМПОНЕНТА ДИСПАНСЕРА
    interface IDispensaryComponent
    {
        bool GiveMeMoneyFromCassette(int Money);
        bool PutTheMoneyOnAccount(int Money);
    }
}
