using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class Power
    {
        public void FindPower()
        {
            Console.WriteLine("Enter the number to find its power");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number upto which you want power");
                int pow = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < pow; i++)
                {
                  double power = Math.Pow(num, i);
                  Console.WriteLine(power);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
