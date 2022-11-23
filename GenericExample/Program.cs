using System;

namespace GenericExample
{
    public class Program<T>
    {

        public bool Compare(T a, T b)
        {


            if (a.Equals(b))

            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program3
    { 
    public  static void Main(string[] args)
        {
            Program<int> obj= new Program<int>();
            Console.WriteLine(obj.Compare(10, 20));
            Program<string> obj2= new Program<string>();

            Console.WriteLine(obj2.Compare("abc","abc"));
            Console.Read();

        }
    }
}
