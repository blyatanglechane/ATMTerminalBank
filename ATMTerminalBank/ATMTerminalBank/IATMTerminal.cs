using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.ATMTerminalBank
{
    // ИНТЕРФЕЙС ТЕРМИНАЛОВ
    interface IATMTerminal
    {
        void PrintSetOperation();
        bool DepositFunds(int Cash);
        bool WithdrawFunds(int SumOfMoneyFromAccount);
        int ToPay(int SumOfMoneyFromAccount, int Cash);
    }
}
