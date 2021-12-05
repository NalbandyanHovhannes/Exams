using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void DelEventHandler();
    class Event
    {

        public static event DelEventHandler add;

        static void Main(string[] args)
        {
            add += new DelEventHandler(USA);
            add += new DelEventHandler(India);
            add += new DelEventHandler(England);
            add.Invoke();

            Console.ReadLine();
        }
        static void USA()
        {
            Console.WriteLine("USA");
        }

        static void India()
        {
            Console.WriteLine("India");
        }

        static void England()
        {
            Console.WriteLine("England");
        }

    }
}
