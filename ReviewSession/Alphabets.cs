using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class Alphabets
    {
      public void PrintAlphabet()
        {
            char ch;
            Console.WriteLine("Alphabets from A to Z are: ");
            for(ch='a'; ch<='z'; ch++)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
