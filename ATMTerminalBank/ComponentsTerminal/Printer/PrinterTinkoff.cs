using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMTerminalBank.ComponentsTerminal.Printer;

namespace ATMTerminalBank.ComponentsTerminal
{
    // печатает чек
    class PrinterTinkoff : IPrinterComponent
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();

        // напечатать чек
        public void PrintReceipt(string Oper, int Money)
        {
            Console.WriteLine("ЧЕК ПО ОПЕРАЦИИ ТИНЬКОФФ\n " +
                "Дата операции: " + DateTime.Today.ToShortDateString() + "\n" +
                 "Время операции: " + DateTime.Now.TimeOfDay.ToString() + "\n" +
                 "Номер документа: " + rnd.Next(100, 999) + "\n");
            if (Oper == "Deposit") Console.WriteLine("Внесено: " + Money + "\n");
            else if (Oper == "Withdraw") Console.WriteLine("Снято: " + Money + "\n");
            else if (Oper == "ToPay") Console.WriteLine("Оплачено: " + Money + "\n");
        }
    }
}
