using ATMTerminalBank.ComponentsTerminal;
using ATMTerminalBank.ComponentsTerminal.Cassette;
using ATMTerminalBank.ComponentsTerminal.Controller;
using ATMTerminalBank.ComponentsTerminal.Dispensary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.ATMTerminalBank
{
    class ATMSberbank : IATMTerminal
    {
        // Диспансер забирания или занесения купюр в кассету
        DispensarySberbank dispensary;

        // Принтер печатающий чек внесения/снятия/оплаты
        PrinterSberbank printer;

        // Контроллер содержаций пользовательский интерфейс для всех видов платежей
        ControllerSberbank controller;

        // Кассета хранящая купюры разного номинала
        CassetteSberbank cassette;

        // конструктор принимающий компоненты терминала
        public ATMSberbank(DispensarySberbank dispensary, PrinterSberbank printer, ControllerSberbank controller, CassetteSberbank cassette)
        {
            this.dispensary = dispensary;
            this.printer = printer;
            this.controller = controller;
            this.cassette = cassette;

        }

        // Вывести список операций
        public void PrintSetOperation()
        {
            Console.WriteLine("Выводим список операций");
            Console.WriteLine("Здравствуйте, вас приветствует терминал Сбербанка!\n" +
                   "Выберите операцию, которую хотите выполнить:\n" +
                   "1. Внести наличные.\n" +
                   "2. Снять наличные.\n" +
                   "3. Оплата услуг.\n" +
                   "4. Выход\n");
        }

        // Внесение средств
        public bool DepositFunds(int Cash)
        {
            Console.WriteLine("Диспансер делает запрос на использование кассеты\n");
            if (dispensary.PutTheMoneyOnAccount(Cash) == true)
            {
                printer.PrintReceipt("Deposit", Cash);
                return true;
            }
            return false;
        }

        // Снятие средств
        public bool WithdrawFunds(int SumOfMoneyFromAccount)
        {
            if (dispensary.GiveMeMoneyFromCassette(SumOfMoneyFromAccount) == true)
            {
                printer.PrintReceipt("Withdraw", SumOfMoneyFromAccount);
                return true;
            }
            return false;
        }

        // Оплата услуг
        public int ToPay(int SumOfMoneyFromAccount, int Cash)
        {
            return controller.CallingTheController(SumOfMoneyFromAccount, Cash, dispensary, printer);
        }
    }
}
