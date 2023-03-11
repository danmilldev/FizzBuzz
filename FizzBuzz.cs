using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzPrint
    {
        public void Print()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
