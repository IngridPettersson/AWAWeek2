﻿using System;
using System.Collections.Generic;

namespace CashMachine
{
    class ProgramCashMachine
    {
        static string[] transactionsArr = new string[10];
        static int totalTransactions;
        static void Main(string[] args)
        {
            double balance = 1000;
            bool exitProgram = false;

            do
            {
                Console.WriteLine("I am your ATM. Press key \"D\", \"W\", \"B\" or \"T\" to choose what you want to do:\n");
                Console.WriteLine("[D]eopist");
                Console.WriteLine("[W]ithdrawal");
                Console.WriteLine("[B]alance");
                Console.WriteLine("[S]how Transactions");
                Console.WriteLine("[T]erminate");
                Console.WriteLine();
                ConsoleKey input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D:
                        balance = MakeDeposit(balance);
                        break;
                    case ConsoleKey.W:
                        balance = MakeWithdrawal(balance);
                        break;
                    case ConsoleKey.B:
                        ShowBalance(balance);
                        break;
                    case ConsoleKey.S:
                        ShowTransactions();
                        break;
                    case ConsoleKey.T:
                        exitProgram = TerminateProgram();
                        break;
                    default:
                        break;
                }
            } while (!exitProgram);
        }

        private static double MakeDeposit(double balance)
        {
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

                //PushLeft(transactionsArr, 1);
                transactionsArr[totalTransactions % transactionsArr.Length] = $"{DateTime.Now}: +{value:C}";
                totalTransactions++;
            }
            Console.WriteLine();
            Console.WriteLine();
            return balance;
        }

        private static double MakeWithdrawal(double balance)
        {
            int value;

            Console.Write("Enter amount you want to withdraw: ");
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

                transactionsArr[totalTransactions % transactionsArr.Length] = $"{DateTime.Now}: -{value:C}";
                totalTransactions++;
            }
            Console.WriteLine();
            Console.WriteLine();
            return balance;
        }

        private static void ShowBalance(double balance)
        {
            Console.Write($"Your current balance is: {balance:C}");
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void ShowTransactions()
        {
            {
                Console.WriteLine("Latest transactions:\n".ToUpper());
                int latestTransaction = (totalTransactions - 1) % transactionsArr.Length;
                //totalTransactions += transactionsArr.Length;
                for (int i = latestTransaction; i >= 0; i--)
                {
                    Console.WriteLine(transactionsArr[i]);
                }
                for (int i = transactionsArr.Length - 1; i > latestTransaction; i--)
                {
                    Console.WriteLine(transactionsArr[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static bool TerminateProgram()
        {
            bool exitProgram;
            Console.WriteLine("Are you sure you want to terminate? ");
            Console.WriteLine();
            Console.WriteLine("[Y]es");
            Console.WriteLine("[N]o");
            if (ConsoleKey.Y == Console.ReadKey(true).Key)
            {
                exitProgram = true;
            }
            else
            {
                exitProgram = false;
            }

            return exitProgram;
        }
    }
}
