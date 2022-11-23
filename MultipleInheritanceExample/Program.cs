using System;

namespace MultipleInheritanceExample
{
    interface Program
    {
        void animal();

    }
    interface Program1
    {
        void cat();
    }
    class Program3 : Program, Program1
    {
      
            public void animal()
            {
                Console.WriteLine("animals makes some noise ");
            }

            public void cat()
            {
                Console.WriteLine("meaow meaow ......");
            }
        public static void Main(string[] args)
        {
            Program3 obj = new Program3();
            obj.animal();
            obj.cat();

            Console.Read();
        }

        

    }       
}