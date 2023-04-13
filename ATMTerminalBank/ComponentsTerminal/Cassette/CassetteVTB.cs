using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.ComponentsTerminal.Cassette
{
    // хранит купюры разного номинала
    class CassetteVTB : ICassetteComponent
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

        // Сумма денег в терминале
        public int SumMoneyFromCassette()
        {
            int sum = 0;
            sum += 5000 * NominalCash[5];
            sum += 2000 * NominalCash[4];
            sum += 1000 * NominalCash[3];
            sum += 500 * NominalCash[2];
            sum += 200 * NominalCash[1];
            sum += 100 * NominalCash[0];
            return sum;
        }

        // Выдать деньги из кассеты (вычитаем купюры из словаря)
        public bool GiveMoney(int money)
        {
            CassetteVTB Casset = new CassetteVTB();
            if (money < Casset.SumMoneyFromCassette())
            {
                while (true)
                {
                    if (money - 5000 >= 0 && NominalCash[5] > 0)
                    {
                        money -= 5000;
                        NominalCash[5] -= 1;
                        Console.WriteLine("Изъята купюра номинала 5000\n");
                    }
                    else break;
                }
                while (true)
                {
                    if (money - 2000 >= 0 && NominalCash[4] > 0)
                    {
                        money -= 2000;
                        NominalCash[4] -= 1;
                        Console.WriteLine("Изъята купюра номинала 2000\n");
                    }
                    else break;
                }
                while (true)
                {
                    if (money - 1000 >= 0 && NominalCash[3] > 0)
                    {
                        money -= 1000;
                        NominalCash[3] -= 1;
                        Console.WriteLine("Изъята купюра номинала 1000\n");
                    }
                    else break;
                }
                while (true)
                {
                    if (money - 500 >= 0 && NominalCash[2] > 0)
                    {
                        money -= 500;
                        NominalCash[2] -= 1;
                        Console.WriteLine("Изъята купюра номинала 500\n");
                    }
                    else break;
                }
                while (true)
                {
                    if (money - 200 >= 0 && NominalCash[1] > 0)
                    {
                        money -= 200;
                        NominalCash[1] -= 1;
                        Console.WriteLine("Изъята купюра номинала 200\n");
                    }
                    else break;
                }
                while (true)
                {
                    if (money - 100 >= 0 && NominalCash[0] > 0)
                    {
                        money -= 100;
                        NominalCash[0] -= 1;
                        Console.WriteLine("Изъята купюра номинала 100\n");
                    }
                    else break;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Извините, на данный момент сумма не может быть выданна " +
                        "из-за отсутствия купюр нужного номинала\n");
                return false;
            }
        }

        // Принять деньги из кассеты (Прибавляем купюры к словарю)
        public bool ReceiveMoney(int money)
        {
            Console.WriteLine("В кассету заносятся деньги\n");
            while (true)
            {
                if (money - 5000 >= 0)
                {
                    money -= 5000;
                    NominalCash[5] += 1;
                    Console.WriteLine("Занесена купюра номинала 5000\n");
                }
                else break;
            }
            while (true)
            {
                if (money - 2000 >= 0)
                {
                    money -= 2000;
                    NominalCash[4] += 1;
                    Console.WriteLine("Занесена купюра номинала 2000\n");
                }
                else break;
            }
            while (true)
            {
                if (money - 1000 >= 0)
                {
                    money -= 1000;
                    NominalCash[3] += 1;
                    Console.WriteLine("Занесена купюра номинала 1000\n");
                }
                else break;
            }
            while (true)
            {
                if (money - 500 >= 0)
                {
                    money -= 500;
                    NominalCash[2] += 1;
                    Console.WriteLine("Занесена купюра номинала 500\n");
                }
                else break;
            }
            while (true)
            {
                if (money - 200 >= 0)
                {
                    money -= 200;
                    NominalCash[1] += 1;
                    Console.WriteLine("Занесена купюра номинала 200\n");
                }
                else break;
            }
            while (true)
            {
                if (money - 100 >= 0)
                {
                    money -= 100;
                    NominalCash[0] += 1;
                    Console.WriteLine("Занесена купюра номинала 100\n");
                }
                else break;
            }
            return true;
        }
    }
}
