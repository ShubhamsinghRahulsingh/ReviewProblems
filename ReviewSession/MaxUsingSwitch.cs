using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class MaxUsingSwitch
    {
        public void FindWithSwitch(int num1, int num2)
        {
            switch (num1 > num2)
            {
                case true:
                    Console.WriteLine("{0} is greater than {1}", num1, num2);
                    break;
                case false:
                    Console.WriteLine("{0} is greater than {1}", num2, num1);
                    break;
            }
        }
        
    }
}
