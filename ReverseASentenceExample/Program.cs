using System;

namespace ReverseASentenceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello Good Morning";
            string[] split1 =s.Split();
              for(int i=split1.Length-1; i>=0; i--)
            {
                Console.Write(split1[i] +" ");
            }
            Console.Read();
        }
    }
}
