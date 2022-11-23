using System;
using System.IO;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            Console.WriteLine("please enter the filepath :");
            string filepath = Console.ReadLine();
            FileInfo fileInfo= new FileInfo(filepath);
            if (!fileInfo.Exists) {
                Console.WriteLine("enter the multiple lines :");
          int     context= int.Parse(Console.ReadLine());
                Console.WriteLine("please enter data \n:");
                for (int i = 0; i < context; i++)
                {
                    str += Console.ReadLine();
                    str +="\n";
                }
           

                StreamWriter sw = new StreamWriter("filepath");
                sw.WriteLine(str);
                sw.Close();
                Console.WriteLine("text create successfully :");

            }
            else
            {
                Console.WriteLine("file path doesnot exist :");
            }
            Console.Read();

        }
    }
}
