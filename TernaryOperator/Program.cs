using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Write a name of somebody in the course: ");
            string input = Console.ReadLine();
            string output = "";

            output = (input.ToUpper() == "HÅKAN") ? "Teacher" : "Consultant";
            Console.WriteLine(output);
        }

    }
}
