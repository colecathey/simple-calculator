using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            float answer;

            Console.WriteLine("What is your 1st number?:\n");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operation are you trying to perform? (+,-,*,/,%)\n");
            operand = Console.ReadLine();

            Console.WriteLine("What is your 2nd number?:\n");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operand)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
                case "%":
                    answer = num1 % num2;
                    break;
                default:
                    answer = 0;
                    break;
            }

            Console.WriteLine("Your answer is " + answer.ToString());
            Console.ReadLine();
        }
    }
}
