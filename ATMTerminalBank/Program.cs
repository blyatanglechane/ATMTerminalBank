using ATMTerminalBank.ATMTerminalBank;
using ATMTerminalBank.ComponentsTerminal;
using ATMTerminalBank.ComponentsTerminal.Cassette;
using ATMTerminalBank.ComponentsTerminal.Controller;
using ATMTerminalBank.ComponentsTerminal.Dispensary;
using ATMTerminalBank.Сlient;
using System;

namespace ATMTerminalBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // имя, сумма на счету, сумма наличных
            BaseClient Alexander = new BaseClient("Александр", 100000, 500);
            BaseClient Semen = new BaseClient("Семён", 2000, 1000);

            // Создаём классы компонентов терминала
            CassetteSberbank ComponentCasset = new CassetteSberbank();
            DispensarySberbank ComponentDispens = new DispensarySberbank();
            PrinterSberbank ComponentPrint = new PrinterSberbank();
            ControllerSberbank ComponentController = new ControllerSberbank();

            // Создаём классы компонентов терминала
            CassetteTinkoff ComponentCasset2 = new CassetteTinkoff();
            DispensaryTinkoff ComponentDispens2 = new DispensaryTinkoff();
            PrinterTinkoff ComponentPrint2 = new PrinterTinkoff();
            ControllerTinkoff ComponentController2 = new ControllerTinkoff();

            // собираем терминал
            IATMTerminal SberTer1 = new ATMSberbank(ComponentDispens, ComponentPrint, ComponentController, ComponentCasset);

            IATMTerminal TinkoffTer1 = new ATMTinkoff(ComponentDispens2, ComponentPrint2, ComponentController2, ComponentCasset2);

            // начало взаимодействия с терминалом и клиентом
            Alexander.interact(TinkoffTer1);

            // безопасный пользовательский ввод
            int InputUser;

            // общий цикл программы
            while (int.TryParse(Console.ReadLine(), out InputUser) && InputUser != 5)
            {
                switch (InputUser)
                {
                    case 1:
                        Console.WriteLine("Внесите наличные: ");
                        int CashInput;
                        while (int.TryParse(Console.ReadLine(), out CashInput))
                        {
                            Alexander.DepositFunds(CashInput);
                            break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Выберите сумму, которую хотите снять: ");
                        int CashInput2;
                        while (int.TryParse(Console.ReadLine(), out CashInput2))
                        {
                            Alexander.WithdrawFunds(CashInput2);
                            break;
                        }
                        break;
                    case 3:
                        Alexander.ToPay();
                        break;
                    case 4:
                        Alexander.PrintAccount();
                        break;
                    case 5:
                        Alexander.Exit();
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция");
                        break;

                }

                // клиент повторно взаимодействует с терминалом
                Alexander.interact(TinkoffTer1);
            }
            Console.WriteLine("Пока......\n");
        }
    }
}
