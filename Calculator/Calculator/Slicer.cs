using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Slicer
    {
        public void InputSlice()
        {
            int num1;
            string operand;
            int num2;

            //get user input
            string userInput = Console.ReadLine();

            //split user input into string array
            string[] allSlicedInputs = userInput.Split();

            //define delimiters to get the numbers inputed and the operands
            char[] numSlice = { '+', '-', '*', '/', '%' };
            //char[] operandSlice = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            foreach(string j in allSlicedInputs)
            {
                if (j == "+")
                {
                    operand = j;
                }
                else if(j == "-")
                {
                    operand = j;
                }
                else if (j == "*")
                {
                    operand = j;
                }
                else if (j == "/")
                {
                    operand = j;
                }
                else if (j == "%")
                {
                    operand = j;
                } else
                {
                    break;
                }
            }


            //returns 2 elements seperated by operands hopefully. this will get num inputs
            string[] numInput = userInput.Split(numSlice,System.StringSplitOptions.RemoveEmptyEntries);

            num1 = int.Parse(numInput[0]);
            num2 = int.Parse(numInput[1]);

            //returns operand from user input
            //string[] operandInput = userInput.Split(operandSlice, System.StringSplitOptions.RemoveEmptyEntries);



            //string userInput = Console.ReadLine();
            //char[] numInput = userInput.Split(delimiterChars);


            //place holder
            //return null;
            
        }
    }
}
