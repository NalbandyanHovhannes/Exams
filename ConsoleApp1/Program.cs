using System;

namespace ConsoleApp1
{
    // Delegate Definition  
    public delegate int operation(int x, int y);

    public class Program
    {
        // Method that is passes as an Argument  
        // It has same signature as Delegates   
       public static int Addition(int a, int b)

        {
            return a * b;
        }

        static void Main(string[] args)
        {
            // Delegate instantiation  
            operation obj = new operation(Program.Addition);

            // output  
            Console.WriteLine("Addition is={0}", obj(23, 27));
            Console.ReadLine();
        }
    }
}


