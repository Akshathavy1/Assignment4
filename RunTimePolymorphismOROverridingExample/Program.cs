using System;

namespace RunTimePolymorphismOROverridingExample
{
    internal class Program
    {
        public virtual void WhatsupApp()
        {
            Console.WriteLine("text message,voice message,status,group,profile");

        }
        }
   
    class Program1 :Program
    {
        public override void WhatsupApp()
        {
            Console.WriteLine("text message,voice message,status,group,status,payments,block,notification");
        }
   
        static void Main(string[] args)
        {
            Program obj = new Program1();
            obj.WhatsupApp();
            Console.Read();
        }
    }
}
