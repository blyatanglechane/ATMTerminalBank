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
        public void interact(IATMTerminal ATM);

        // Показать количество денег на счёте
        public void PrintAccount();

        // Внесение средств
        public void DepositFunds(int Cash);

        // Снятие средств
        public void WithdrawFunds(int SumOfMoneyFromAccount);

        // Оплата услуг
        public void ToPay();

        // Выйти из главного меню банкомата
        public void Exit();
    }
}
