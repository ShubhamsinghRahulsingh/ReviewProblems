using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class ASCIIValues
    {
        public void PrintASCII()
        {
            char ch;
            Console.WriteLine("For ASCII Values\nSelect 1.For Upper Case\n2.For Lower Case");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        for (ch = 'A'; ch <= 'Z'; ch++)
                        {
                            Console.WriteLine("ASCII value of " + ch + " is " + Convert.ToInt32(ch));
                        }
                        break;
                    case 2:
                        for (ch = 'a'; ch <= 'z'; ch++)
                        {
                            Console.WriteLine("ASCII value of " + ch + " is " + Convert.ToInt32(ch));
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
