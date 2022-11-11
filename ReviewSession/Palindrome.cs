using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class Palindrome
    {
        public void CheckPalindrome()
        {
            int remainder = 0,sum=0;
            Console.WriteLine("Enter the number which you want to check");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                int check = num;
                while (num > 0)
                {
                    remainder = num % 10;
                    sum = sum * 10 + remainder;
                    num = num / 10;
                }
                if (sum == check)
                {
                    Console.WriteLine("The given Number is Palindrome");
                }
                else
                {
                    Console.WriteLine("The given Number is not Palindrome");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
