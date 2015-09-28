using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Counter
    {
        public string counter()
        {


            int ctr = 0;
            string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine("Line {0}: {1}", ctr, s);
                ctr++;

            } while (true);            
                                         
         }
            
      }

}

