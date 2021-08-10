using System;
using AdditionalTask.ColoredLines;

namespace AdditionalTask
{
    class Program
    {
        public static string text;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to be printed:");
            text = Console.ReadLine();
            Console.Clear();

            Printer printer = new Printer();
            printer.Print(text);

            printer = new Red();
            printer.Print(text);

            printer = new Green();
            printer.Print(text);

            printer = new Blue();
            printer.Print(text);

            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
