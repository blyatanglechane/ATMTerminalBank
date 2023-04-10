using ATMTerminalBank.ComponentsTerminal.Dispensary;
using ATMTerminalBank.ComponentsTerminal.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.ComponentsTerminal.Controller
{
    class ControllerVTB : IControllerComponent
    {
        public int CallingTheController(int SumOfMoneyFromAccount, int Cash, IDispensaryComponent dispensary, IPrinterComponent printer)
        {
            Dictionary<string, int> SetPaiment = new Dictionary<string, int>()
            {
                {"Коммунальные услуги", 3000 },
                {"Сотовая связь", 300 },
                {"Оплата интернета", 900 }
            };
            Console.WriteLine("Какую услугу вы хотите оплатить?:\n" +
                    "1. Коммунальные услуги (3000 рублей).\n" +
                    "2. Сотовая связь (300 рублей)\n" +
                    "3. Оплатить интернет (900 рублей)\n" +
                    "4. Выход\n");
            while (true)
            {
                string input = Console.ReadLine();
                int InputUser = int.Parse(input);
                switch (InputUser)
                {
                    case 1:
                        Console.WriteLine("Какой способ оплаты вы выберете?\n" +
                            "1. Наличные\n" +
                            "2. Списать с аккаунта\n");
                        string input2 = Console.ReadLine();
                        int InputUser2 = int.Parse(input2);
                        if (InputUser2 == 1)
                        {
                            if (Cash - 3000 > 0)
                            {
                                if (dispensary.PutTheMoneyOnAccount(3000) == true)
                                {
                                    printer.PrintReceipt("ToPay", 3000);
                                    return -3000;
                                }
                                else return 0;
                            }
                            else
                            {

                                Console.WriteLine("У клиента недостаточно наличных для оплаты услуги\n"
                                    + "Доступные услуги:\n");
                                int Counter = 1;
                                foreach (KeyValuePair<string, int> pair in SetPaiment)
                                {
                                    if (Cash > pair.Value) Console.WriteLine(Counter + ". " + pair.Key + "  <- Достаточно для оплаты");
                                    else Console.WriteLine(Counter + ". " + pair.Key + "  Недостаточно средств!");
                                    Counter++;
                                }
                                Console.WriteLine("4. Выход");
                                continue;
                            }
                        }
                        else if (InputUser2 == 2)
                        {
                            if (SumOfMoneyFromAccount - 3000 < 0)
                            {
                                Console.WriteLine("На счёте недостаточно средств\n"
                                     + "Доступные услуги:\n");
                                int Counter = 1;
                                foreach (KeyValuePair<string, int> pair in SetPaiment)
                                {
                                    if (SumOfMoneyFromAccount > pair.Value) Console.WriteLine(Counter + ". " + pair.Key + "  <- Достаточно для оплаты");
                                    else Console.WriteLine(Counter + ". " + pair.Key + "  Недостаточно средств!");
                                    Counter++;
                                }
                                Console.WriteLine("4. Выход");
                                continue;
                            }
                            else if (dispensary.PutTheMoneyOnAccount(3000) == true)
                            {
                                printer.PrintReceipt("ToPay", 3000);
                                return 3000;
                            }
                            else return 0;

                        }
                        else
                        {
                            Console.WriteLine("Неизвестная операция\n");
                            return 0;
                        }
                    case 2:
                        Console.WriteLine("Какой способ оплаты вы выберете?\n" +
                            "1. Наличные\n" +
                            "2. Списать с аккаунта\n");
                        string input3 = Console.ReadLine();
                        int InputUser3 = int.Parse(input3);
                        if (InputUser3 == 1)
                        {
                            if (Cash - 300 > 0)
                            {
                                if (dispensary.PutTheMoneyOnAccount(300) == true)
                                {
                                    printer.PrintReceipt("ToPay", 300);
                                    return -300;
                                }
                                else return 0;
                            }
                            else
                            {
                                Console.WriteLine("У клиента недостаточно наличных для оплаты услуги\n"
                                    + "Доступные услуги:\n");
                                int Counter = 1;
                                foreach (KeyValuePair<string, int> pair in SetPaiment)
                                {
                                    if (Cash > pair.Value) Console.WriteLine(Counter + ". " + pair.Key + "  <- Достаточно для оплаты");
                                    else Console.WriteLine(Counter + ". " + pair.Key + "  Недостаточно средств!");
                                    Counter++;
                                }
                                Console.WriteLine("4. Выход");
                                continue;
                            }
                        }
                        else if (InputUser3 == 2)
                        {
                            if (SumOfMoneyFromAccount - 300 < 0)
                            {
                                Console.WriteLine("На счёте недостаточно средств\n"
                                + "Доступные услуги:\n");
                                int Counter = 1;
                                foreach (KeyValuePair<string, int> pair in SetPaiment)
                                {
                                    if (SumOfMoneyFromAccount > pair.Value) Console.WriteLine(Counter + ". " + pair.Key + "  <- Достаточно для оплаты");
                                    else Console.WriteLine(Counter + ". " + pair.Key + "  Недостаточно средств!");
                                    Counter++;
                                }
                                Console.WriteLine("4. Выход");
                                continue;

                            }
                            else if (dispensary.PutTheMoneyOnAccount(300) == true)
                            {
                                printer.PrintReceipt("ToPay", 300);
                                return 300;
                            }
                            else return 0;

                        }
                        else
                        {
                            Console.WriteLine("Неизвестная операция\n");
                            return 0;
                        }
                    case 3:
                        Console.WriteLine("Какой способ оплаты вы выберете?\n" +
                            "1. Наличные\n" +
                            "2. Списать с аккаунта\n");
                        string input4 = Console.ReadLine();
                        int InputUser4 = int.Parse(input4);
                        if (InputUser4 == 1)
                        {
                            if (Cash - 900 > 0)
                            {
                                if (dispensary.PutTheMoneyOnAccount(900) == true)
                                {
                                    printer.PrintReceipt("ToPay", 900);
                                    return -900;
                                }
                                else return 0;
                            }
                            else
                            {
                                Console.WriteLine("У клиента недостаточно наличных для оплаты услуги\n"
                                + "Доступные услуги:\n");
                                int Counter = 1;
                                foreach (KeyValuePair<string, int> pair in SetPaiment)
                                {
                                    if (Cash > pair.Value) Console.WriteLine(Counter + ". " + pair.Key + "  <- Достаточно для оплаты");
                                    else Console.WriteLine(Counter + ". " + pair.Key + "  Недостаточно средств!");
                                    Counter++;
                                }
                                Console.WriteLine("4. Выход");
                                continue;
                            }
                        }
                        else if (InputUser4 == 2)
                        {
                            if (SumOfMoneyFromAccount - 900 < 0)
                            {
                                Console.WriteLine("На счёте недостаточно средств\n"
                                + "Доступные услуги:\n");
                                int Counter = 1;
                                foreach (KeyValuePair<string, int> pair in SetPaiment)
                                {
                                    if (SumOfMoneyFromAccount > pair.Value) Console.WriteLine(Counter + ". " + pair.Key + "  <- Достаточно для оплаты");
                                    else Console.WriteLine(Counter + ". " + pair.Key + "  Недостаточно средств!");
                                    Counter++;
                                }
                                Console.WriteLine("4. Выход");
                                continue;
                            }
                            else if (dispensary.PutTheMoneyOnAccount(900) == true)
                            {
                                printer.PrintReceipt("ToPay", 900);
                                return 900;
                            }
                            else return 0;

                        }
                        else
                        {
                            Console.WriteLine("Неизвестная операция\n");
                            return 0;
                        }
                    case 4:
                        return 0;
                    default:
                        Console.WriteLine("Неизвестная операция\n");
                        return 0;

                }
            }
        }
    }
}
