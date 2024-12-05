using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Great! So your name is " + name + "\n" + 
                "Welcome to our lesson!");
            Console.ReadKey();
        }
    }
}
