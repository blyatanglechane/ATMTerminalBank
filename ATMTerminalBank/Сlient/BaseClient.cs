using ATMTerminalBank.ATMTerminalBank;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTerminalBank.Сlient
{
    class BaseClient : IClient
    {
        // Имя клиента
        string Name = "NoName";

        // Сумма денег на счету 
        int SumOfMoneyFromAccount = 0;

        // Сумма наличных у клиента
        int Сash = 0;

        // Используемый терминал
        IATMTerminal CurrentTerminal;

        // конструктор класса
        public BaseClient(string Name, int SumOfMoneyFromAccount, int Cash)
        {
            this.Name = Name;
            this.SumOfMoneyFromAccount = SumOfMoneyFromAccount;
            this.Сash = Cash;
        }

        // Взаимодействие клиента с ATM терминалом
        public void interact(IATMTerminal CurrentTerminal)
        {
            Console.WriteLine("Клиент выбрал терминал\n");
            this.CurrentTerminal = CurrentTerminal;
            CurrentTerminal.PrintSetOperation();
        }

        // Выводит сколько наличных с собой имеет клиент и баланс его счёта
        public void PrintAccount()
        {
            Console.WriteLine("Наличных с собой: " + Сash + "\n" +
                "Денег на счету: " + SumOfMoneyFromAccount + "\n");
        }

        // клиент хочет внести деньги
        public void DepositFunds(int cash)
        {
            Console.WriteLine("Проверка на внесённость купюр\n");
            if (CurrentTerminal != null)
            {
                if (cash > this.Сash || cash < 0)
                {
                    Console.WriteLine("Диспансер не обнаружил купюры\n");
                    Console.WriteLine("У клиента нету таких наличных\n");
                }
                else
                {
                    Console.WriteLine("Запускается процесс занесения денег на счёт\n");
                    if (CurrentTerminal.DepositFunds(cash) == true) { this.SumOfMoneyFromAccount += cash; this.Сash -= cash; Console.WriteLine("Деньги зачислились на счёт\n"); }
                }
            }
            else Console.WriteLine("Клиент не выбрал терминал\n");
        }

        // клиент хочет снять наличные
        public void WithdrawFunds(int SumOfMoneyFromAccount)
        {
            if (CurrentTerminal != null)
            {
                if (SumOfMoneyFromAccount > this.SumOfMoneyFromAccount || SumOfMoneyFromAccount < 0)
                    Console.WriteLine("На вашем счёте недостаточно средств\n");
                else
                {
                    Console.WriteLine("Запускается процесс снятия денег с счёта\n");
                    if (CurrentTerminal.WithdrawFunds(SumOfMoneyFromAccount) == true) 
                    { 
                        this.SumOfMoneyFromAccount -= SumOfMoneyFromAccount; 
                        this.Сash += SumOfMoneyFromAccount; 
                        Console.WriteLine("Деньги зачислились на счёт\n"); 
                    }
                }
            }
            else Console.WriteLine("Клиент не выбрал терминал\n");

        }

        // клиент хочет оплатить услугу
        public void ToPay()
        {
            if (CurrentTerminal != null)
            {
                int index = CurrentTerminal.ToPay(SumOfMoneyFromAccount, this.Сash);
                if (index >= 0)
                    SumOfMoneyFromAccount -= index;
                else this.Сash += index;
            }
            else Console.WriteLine("Клиент не выбрал терминал\n");
        }

        // клиент вышел из меню терминала
        public void Exit()
        {
            CurrentTerminal = null;
        }
    }
}
