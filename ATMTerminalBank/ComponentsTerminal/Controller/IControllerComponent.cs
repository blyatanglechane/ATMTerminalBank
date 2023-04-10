using ATMTerminalBank.ComponentsTerminal.Dispensary;
using ATMTerminalBank.ComponentsTerminal.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.ComponentsTerminal.Controller
{
    // ИНТЕРФЕЙС КОМПОНЕНТА КОНТРОЛЛЕРА
    interface IControllerComponent
    {
        public int CallingTheController(int SumOfMoneyFromAccount, int Cash, 
            IDispensaryComponent dispensary, IPrinterComponent printer);
    }
}
