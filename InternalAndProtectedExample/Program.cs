using System;

namespace InternalAndProtectedExample
{

  internal class Program
    {
        protected internal string StudentName;
        protected internal int StudentId;
        protected internal void Student()
        {
            Console.WriteLine("Name =" + StudentName);
            Console.WriteLine("Id=" + StudentId);
        }
    }
   class Program1 
    { 
        static void Main(string[] args)
        {
            Program obj= new Program();
            obj.StudentName = "kavin";
            obj.StudentId = 25;
            obj.Student();
            Console.Read();
        }
    }
}
