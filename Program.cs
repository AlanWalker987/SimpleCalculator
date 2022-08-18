using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("------------Calculator Operations-------------------");

            Console.WriteLine("Enter First Number");
            double firstnum = double.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("Enter Second Number");
                double secondNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Choose the operation you want to perform - (+, -, *, /)");
                char op = char.Parse(Console.ReadLine());

                CalculatorMachine cm = new CalculatorMachine(firstnum, secondNum, op);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
           

           
        }
    }

}
