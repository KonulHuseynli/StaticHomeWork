using System;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            Person konul = new Person();
            konul.Name = "konul";
           
            Person Aysun = new Person();
            konul.Name = "Aysun";

            Person Mirsaleh = new Person();
            konul.Name = "Mirsaleh";

            Person Nurlan = new Person();
            konul.Name = "Nurlan";

            konul.count();
            Console.WriteLine(konul.getAge());
            Aysun.count();
            Console.WriteLine(Aysun.getAge());
            Mirsaleh.count();
            Console.WriteLine(Mirsaleh.getAge());
            Nurlan.count();
            Console.WriteLine(Nurlan.getAge());
        }
    }
}
