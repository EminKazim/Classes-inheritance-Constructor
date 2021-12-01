using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    class Factorial : Program
    {
        int num;
        public Factorial(int num)
        {
            this.num = num;
        }


        public void numFactorial()
        {
            int multiply = 1;
            if (this.num == 0)
            {
                Console.WriteLine(0);
            }
            else if (this.num < 0)
            {
                Console.WriteLine("wrong number");
            }
            else
            {


                for (int i = 1; i <= this.num; i++)
                {

                    multiply = multiply * i;

                }
                Console.WriteLine(multiply);
            }


        }
    }
}

      