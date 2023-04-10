using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.ComponentsTerminal.Printer
{
    // ИНТЕРФЕЙС КОМПОНЕНТА ПРИНТЕРА
    interface IPrinterComponent
    {
        public void PrintReceipt(string Oper, int Money);
    }
}
