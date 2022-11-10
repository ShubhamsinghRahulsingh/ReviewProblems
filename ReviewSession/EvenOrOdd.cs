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
            Console.WriteLine("Enter the number which you want to check");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Given Number is an even number");
            }
            else
                Console.WriteLine("Given Number is odd Number");
        }
    }
}
