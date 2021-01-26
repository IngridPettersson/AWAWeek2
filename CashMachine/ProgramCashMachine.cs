using System;
using System.Collections.Generic;

namespace CashMachine
{
    class ProgramCashMachine
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I am your ATM. Press key D, W, B or T to choose what you want to do:\n");
            Console.WriteLine("[D]eopist");
            Console.WriteLine("[W]ithdrawal");
            Console.WriteLine("[B]alance");
            Console.WriteLine("[T]erminate");
            Console.WriteLine();
            ConsoleKey input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.D:
                    MakeDeposit();
                    break;
                case ConsoleKey.W:
                    MakeWithdrawal();
                    break;
                case ConsoleKey.B:
                    Console.Write("Your current balance is: \n");
                    ShowSaldo();
                    break;
                case ConsoleKey.T:
                    Console.Write("Are you sure you want to terminate? \n");
                    TerminateProgram();
                    break;
                default:
                    break;
            }
        }

        private static double MakeDeposit()
        {
            double balance = 1000;
            int value;

            Console.Write("Enter amount you want to deposit: ");
            bool isInt = int.TryParse(Console.ReadLine(), out value);


            while (!isInt || value <= 0)
            {
                Console.Write("Enter a valid integer higher than 0: ");
                isInt = int.TryParse(Console.ReadLine(), out value);
            }

            if (isInt && value > 0)
            {
                Console.WriteLine($"You have deposited {value:C}.");
                balance += value;
                Console.WriteLine($"Current balance: {balance:C}");
            }

            return balance;
        }

        private static double MakeWithdrawal()
        {
            double balance = 1000;
            int value;

            Console.Write("Enter amount you want to withdraw: \n");
            bool isInt = int.TryParse(Console.ReadLine(), out value);
            bool enoughMoney = balance >= value;

            while (!isInt || value <= 0 || !enoughMoney)
            {
                if (!isInt || value <= 0)
                {
                    Console.Write("Enter a valid integer higher than 0: ");
                    isInt = int.TryParse(Console.ReadLine(), out value);
                    enoughMoney = balance >= value;
                }
                else if (!enoughMoney)
                {
                    Console.Write($"You do not have enough money in your account. Enter an amount of maximum {balance:C}: ");
                    isInt = int.TryParse(Console.ReadLine(), out value);
                    enoughMoney = balance >= value;
                }
            }

            if (isInt && value > 0 && enoughMoney)
            {
                Console.WriteLine($"You have successfully withdrawn {value:C}.");
                balance -= value;
                Console.WriteLine($"Current balance: {balance:C}");
            }
            return balance;
        }

        private static void ShowSaldo()
        {
            Console.WriteLine("Show saldo...");
        }

        private static void TerminateProgram()
        {
            Console.WriteLine("Terminate program...");
        }
    }
}
