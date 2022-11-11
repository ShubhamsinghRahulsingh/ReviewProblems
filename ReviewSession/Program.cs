using ReviewSession;
using System;
namespace Practice1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Review Session");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect From the below options");
                Console.WriteLine("1.EvenOrOdd\n2.PositveNegativeOrZero\n3.Alphabets\n4.MultiplicationTable\n5.Factorial\n6.Palindrome\n7.Power\n8.ASCIIValues\n9.Exit");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        EvenOrOdd check = new EvenOrOdd();
                        check.Check();
                        break;
                    case 2:
                        CheckNumber number = new CheckNumber();
                        number.Number();
                        break;
                    case 3:
                        Alphabets alphabets = new Alphabets();
                        alphabets.PrintAlphabet();
                        break;
                    case 4:
                        MultiplicationTable table=new MultiplicationTable();
                        table.Table();
                        break;
                    case 5:
                        Factorial factorial = new Factorial();
                        factorial.Find();
                        break;
                    case 6:
                        Palindrome palindrome = new Palindrome();
                        palindrome.CheckPalindrome();
                        break;
                    case 7:
                        Power power = new Power();
                        power.FindPower();
                        break;
                    case 8:
                        ASCIIValues print = new ASCIIValues();
                        print.PrintASCII();
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }

        }
    }
}