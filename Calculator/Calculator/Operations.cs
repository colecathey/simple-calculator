using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operations
    {
        public int num1
        {
            get; set;
        }
        public int num2
        {
            get; set;
        }
        public string operand
        {
            get; set;
        }
        public static decimal answer;
        

        public static decimal add(decimal num1, decimal num2)
        {
            answer = num1 + num2;
            return answer;
        }
        public float subtract()
        {
            answer = num1 - num2;
            return answer;
        }
        public float multiply()
        {
            answer = num1 * num2;
            return answer;
        }
        public float divide()
        {
            answer = num1 / num2;
            return answer;
        }
        public float modulus()
        {
            answer = num1 % num2;
            return answer;
        }




    }
}
