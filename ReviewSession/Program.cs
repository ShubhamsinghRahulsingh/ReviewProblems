using System;
using ReviewSession;
namespace ReviewSession
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Review Session");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("________________________________________________________\n");
                Console.WriteLine("Select From the below options");
                Console.WriteLine("1.EvenOrOdd\n2.PositveNegativeOrZero\n3.Alphabets\n4.MultiplicationTable\n5.Factorial\n6.Palindrome\n7.Power\n8.ASCIIValues\n9.AreaOfCircle\n10.Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
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
                        AreaOfCircle area=new AreaOfCircle();
                        area.Area();
                        break;
                    case 10:
                        flag = false;
                        break;
                }
            }

        }
    }
}