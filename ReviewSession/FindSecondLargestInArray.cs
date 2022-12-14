using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class FindSecondLargestInArray
    {
        int[] array = { 67, 25, 19, 9, 42, 26, 32, 29 };
        public void FindSecondLargest()
        {
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Second Largest Element in Array is :" + array[1]);
        }
    }
}
