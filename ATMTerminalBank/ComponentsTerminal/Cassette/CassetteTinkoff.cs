using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.ComponentsTerminal.Cassette
{
    // хранит купюры разного номинала
    class CassetteTinkoff : ICassetteComponent
    {
        // NominalCash[0] -> Содержит количество купюр по 100 рублей; NominalCash[1] = 200 рублей; NominalCash[2] = 500 рублей; и т.д.
        // размер 6 элементов, по 10 купюр каждого номинала изначально
        Dictionary<int, int> NominalCash = new Dictionary<int, int>()
        {
            {0, 10 },
            {1, 10 },
            {2, 10 },
            {3, 10 },
            {4, 10 },
            {5, 10 }
        };

        // Выдать деньги из кассеты (вычитаем купюры из словаря)
        public bool GiveMoney(int money)
        {
            while (true)
            {
                if (money - 5000 >= 0 && NominalCash[5] > 0)
                {
                    money -= 5000;
                    NominalCash[5] -= 1;
                }
                else break;
            }
            while (true)
            {
                if (money - 2000 >= 0 && NominalCash[4] > 0)
                {
                    money -= 2000;
                    NominalCash[4] -= 1;
                }
                else break;
            }
            while (true)
            {
                if (money - 1000 >= 0 && NominalCash[3] > 0)
                {
                    money -= 1000;
                    NominalCash[3] -= 1;
                }
                else break;
            }
            while (true)
            {
                if (money - 500 >= 0 && NominalCash[2] > 0)
                {
                    money -= 500;
                    NominalCash[2] -= 1;
                }
                else break;
            }
            while (true)
            {
                if (money - 200 >= 0 && NominalCash[1] > 0)
                {
                    money -= 200;
                    NominalCash[1] -= 1;
                }
                else break;
            }
            while (true)
            {
                if (money - 100 >= 0 && NominalCash[0] > 0)
                {
                    money -= 100;
                    NominalCash[0] -= 1;
                }
                else break;
            }
            if (money > 0)
            {
                Console.WriteLine("Извините, на данный момент сумма не может быть выданна " +
                    "из-за отсутствия купюр нужного номинала\n");
                return false;
            }
            return true;
        }

        // Принять деньги из кассеты (Прибавляем купюры к словарю)
        public bool ReceiveMoney(int money)
        {
            while (true)
            {
                if (money - 5000 >= 0)
                {
                    money -= 5000;
                    NominalCash[5] += 1;
                }
                else break;
            }
            while (true)
            {
                if (money - 2000 >= 0)
                {
                    money -= 2000;
                    NominalCash[4] += 1;
                }
                else break;
            }
            while (true)
            {
                if (money - 1000 >= 0)
                {
                    money -= 1000;
                    NominalCash[3] += 1;
                }
                else break;
            }
            while (true)
            {
                if (money - 500 >= 0)
                {
                    money -= 500;
                    NominalCash[2] += 1;
                }
                else break;
            }
            while (true)
            {
                if (money - 200 >= 0)
                {
                    money -= 200;
                    NominalCash[1] += 1;
                }
                else break;
            }
            while (true)
            {
                if (money - 100 >= 0)
                {
                    money -= 100;
                    NominalCash[0] += 1;
                }
                else break;
            }
            return true;
        }
    }
}
