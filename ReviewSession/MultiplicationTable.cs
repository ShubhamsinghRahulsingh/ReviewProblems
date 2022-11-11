using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class MultiplicationTable
    {
        public void Table()
        {
            const int max = 10;
            Console.WriteLine("Enter the number for which you want multiplication Table");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= max; i++)
                {
                    int Table = number * i;
                    Console.WriteLine("{0}*{1}= " + Table, number, i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
