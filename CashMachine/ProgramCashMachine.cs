using System;
using System.Collections.Generic;

namespace CashMachine
{
    class ProgramCashMachine
    {
        static void Main(string[] args)
        {
            // Ge användaren alternativen.
            // Sätta de olika alternativen som variabler.
            // Göra ett switch statement för varje alternativ och vad som då ska hända.
            // 

            //            …med hjälp av en switch sats skapar en inmatningsmeny för en bankomat. Alternativen ska
            //            vara:
            //            [I]nsättning
            //            [U]ttag
            //            [S]aldo
            //            [A]vsluta

            Console.WriteLine("I am your ATM. Enter key D, W, B or E\n");
            Console.WriteLine("[D]eopist");
            Console.WriteLine("[W]ithdrawal");
            Console.WriteLine("[B]alance");
            Console.WriteLine("[T]erminate");
            Console.WriteLine();
            ConsoleKey input = Console.ReadKey().Key;

            //List<ConsoleKeyInfo> validKeys = new List<ConsoleKeyInfo>();
            //validKeys.Add(ConsoleKeyInfo.I);
            //validKeys.Add(ConsoleKey.U);
            //validKeys.Add(ConsoleKey.S);
            //validKeys.Add(ConsoleKey.A);

            //foreach (var key in validKeys)
            //{
            switch (input)
            {
                case ConsoleKey.D:
                    Console.Write("Enter amount you want to deposit: ");
                    break;
                case ConsoleKey.W:
                    Console.Write("Enter amount you want to withdraw: ");
                    break;
                case ConsoleKey.B:
                    Console.Write("Your current balance is: ");
                    break;
                case ConsoleKey.E:
                    Console.Write("Are you sure you want to terminate? ");
                    break;
                default:
                    break;
            }
            //}
        }
    }
}
