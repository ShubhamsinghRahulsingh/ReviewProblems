using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class EvenOrOdd
    {
        public void Check()
        {
            Console.WriteLine("Enter the number to check whether its odd or even");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Given Number is an even number");
                }
                else
                    Console.WriteLine("Given Number is odd Number");
            }
           catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
