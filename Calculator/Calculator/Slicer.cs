using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Slicer
    {
        public string inputSlice()
        {
            //int num1;
            //string operand;
            //int num2;

            //get user input
            string userInput = Console.ReadLine();

            //split user input into string array
            string[] slicedInputs = userInput.Split();

            //define delimiters to get the numbers inputed and the operands
            char[] numSlice = { '+', '-', '*', '/', '%' };
            char[] operandSlice = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            //returns 2 elements seperated by operands hopefully. this will get num inputs
            string[] numInput = userInput.Split(numSlice,2, System.StringSplitOptions.RemoveEmptyEntries);

            //returns operand from user input
            string[] operandInput = userInput.Split(operandSlice, System.StringSplitOptions.RemoveEmptyEntries);

            for (var i = 0; i < slicedInputs.Length; i++)
            {
                
                                                                  
            }

            //string userInput = Console.ReadLine();
            //char[] numInput = userInput.Split(delimiterChars);

            
            //place holder
            return null;
        }
    }
}
