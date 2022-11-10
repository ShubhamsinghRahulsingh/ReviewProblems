using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class CheckNumber
    { 
            public void Number()
            {
                Console.WriteLine("Enter the Number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine("The given number is Positive");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The given number is Negative");
                }
                else
                    Console.WriteLine("The number is zero");
            }
    }
}
