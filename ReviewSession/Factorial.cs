using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class Factorial
    {
        public void Find()
        {
            int factorial = 1;
            Console.WriteLine("Enter the number to find factorial");
            try
            {
                int fact = Convert.ToInt32(Console.ReadLine());
                while (fact > 0)
                {
                    factorial = fact * factorial;
                    fact--;
                }
                Console.WriteLine("Factorial of a given Number is: " + factorial);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
