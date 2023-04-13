using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMTerminalBank.ComponentsTerminal.Cassette;

namespace ATMTerminalBank.ComponentsTerminal.Dispensary
{
    // Распознаёт номинал купюр, набирает купюры для выдачи
    class DispensaryTinkoff : IDispensaryComponent
    {
        // Кассета, с которой взаимодействует Диспансер
        CassetteSberbank CurrentCassette = new CassetteSberbank();

        // запрос к кассете на получение денег
        public bool GiveMeMoneyFromCassette(int Money)
        {
            if (Money % 100 == 0)
            {
                if (CurrentCassette.GiveMoney(Money) == true) return true;
                else return false;
            }
            else { Console.WriteLine("Данная сумма не может быть выдана\n"); return false; }
        }

        // запрос к кассете на внесение денег
        public bool PutTheMoneyOnAccount(int Money)
        {
            if (Money % 100 == 0 && Money > 0) { CurrentCassette.ReceiveMoney(Money); return true; }
            else { Console.WriteLine("Данная сумма не может быть занесена\n"); return false; }
        }
    }
}
