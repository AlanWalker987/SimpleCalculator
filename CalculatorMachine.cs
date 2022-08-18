using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class CalculatorMachine
    {
        private double firstNumber;
        private double secondNumber;
        private double result;
        private char operation;

        public CalculatorMachine(double first, double second, char op)
        {
            firstNumber = first;
            secondNumber = second;
            operation = op;
            switching();
        }

        private void switching()
        {
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"Addition of {firstNumber} and {secondNumber} is {result}");
                    startover();
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"Difference of {firstNumber} and {secondNumber} is {result}");
                    startover();
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"Multiplication of {firstNumber} and {secondNumber} is {result}");
                    startover(); 
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"Division of {firstNumber} and {secondNumber} is {result}");
                    startover();
                    break;
                default: Console.WriteLine("Invalid Operator. Please enter the valid operator");
                    end();
                    break;
            }
        }

        private void startover()
        {
            Console.WriteLine("You want to continue ? Press 'Y' to continue else press any key to exit");
            char YesorNo = char.Parse(Console.ReadLine());
            bool response = (YesorNo == 'Y' || YesorNo == 'y');

            if (response)
            {
                repeat();
            }
            else
            {
                end();
            }

        }

        private void repeat()
        {
            firstNumber = result;
            try
            {
                Console.WriteLine("Enter the second number");
                secondNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose the Operation");
                operation = char.Parse(Console.ReadLine());

                switching();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void end()
        {
            Console.WriteLine($"Final Result is {result}");
            Console.WriteLine("Press any key to exit the calculator");
            Console.ReadLine();
        }
    }
}
