using ATMTerminalBank.ATMTerminalBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.Сlient
{
    interface IClient
    {
        // взаимодействие с терминалом
        void interact(IATMTerminal ATM);

        // Внесение средств
        public void DepositFunds(int Cash);

        // Снятие средств
        void WithdrawFunds(int SumOfMoneyFromAccount);

        // Оплата услуг
        public void ToPay();

        // Выйти из главного меню банкомата
        public void Exit();
    }
}
