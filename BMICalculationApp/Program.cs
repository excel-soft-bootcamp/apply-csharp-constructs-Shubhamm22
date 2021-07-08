using System;
using System.IO;
using System.Collections.Generic;

namespace BMICalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int value = default;
            do
            {


                Console.WriteLine("Select Method to Display BMI");
                Console.WriteLine("1.Console Input");
                Console.WriteLine("2.File Input");
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < 1 || value > 2)
                    {
                        Console.WriteLine("Invalid Input");
                    }


                    else { break; }
                }
                catch (FormatException ex) { Console.WriteLine("Input only in number"); }
            } while (true);
            switch (value)
            {
                case 1:

                    ConsoleInput _consoleInput = new ConsoleInput();
                    _consoleInput.Display();
                    break;
                    case 2:

            }

        }
    }
}




