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
                Console.WriteLine("Select From the below options");
                Console.WriteLine("1.EvenOrOdd 2.PositveNegativeOrZero 3.Exit");
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
                        flag = false;
                        break;
                }
            }

        }
    }
}