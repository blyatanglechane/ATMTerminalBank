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
            BaseClient Alexander = new BaseClient("Александр", 4000, 500);
            BaseClient Semen = new BaseClient("Семён", 2000, 1000);

            // Создаём классы компонентов терминала
            CassetteSberbank ComponentCasset = new CassetteSberbank();
            DispensarySberbank ComponentDispens = new DispensarySberbank();
            PrinterSberbank ComponentPrint = new PrinterSberbank();
            ControllerSberbank ComponentController = new ControllerSberbank();

            // собираем терминал
            IATMTerminal SberTer1 = new ATMSberbank(ComponentDispens, ComponentPrint, ComponentController, ComponentCasset);

            // начало взаимодействия с терминалом и клиентом
            Alexander.interact(SberTer1);

            // безопасный пользовательский ввод
            int InputUser;

            // общий цикл программы
            while (int.TryParse(Console.ReadLine(), out InputUser) && InputUser != 4)
            {
                switch (InputUser)
                {
                    case 1:
                        Console.WriteLine("Внесите наличные: ");
                        string CashStr = Console.ReadLine();
                        int CashInput = int.Parse(CashStr);
                        Alexander.DepositFunds(CashInput);
                        break;
                    case 2:
                        Console.WriteLine("Выберите сумму, которую хотите снять: ");
                        string CashStr2 = Console.ReadLine();
                        int CashInput2 = int.Parse(CashStr2);
                        Alexander.WithdrawFunds(CashInput2);
                        break;
                    case 3:
                        Alexander.ToPay();
                        break;
                    case 4:
                        Alexander.Exit();
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция");
                        break;

                }

                // клиент повторно взаимодействует с терминалом
                Alexander.interact(SberTer1);
            }
        }
    }
}
