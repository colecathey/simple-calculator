using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    
    class Program : Operations
    {
        static void Main(string[] args)
        {
            decimal num1;
            decimal num2;
            string operand;
            decimal answer;

            Console.WriteLine("What is your 1st number?:\n");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What operation are you trying to perform? (+,-,*,/,%)\n");
            operand = Console.ReadLine();

            Console.WriteLine("What is your 2nd number?:\n");
            num2 = Convert.ToDecimal(Console.ReadLine());

            if (operand == "+")
            {
                answer = add(num1, num2);               
            } else if (operand == "-")
            {
                answer = subtract(num1, num2);
            }

            
            Console.WriteLine("Your answer is " + answer.ToString());
            Console.ReadLine();
        }
    }
}
