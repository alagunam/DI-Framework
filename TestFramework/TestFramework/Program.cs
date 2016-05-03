using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiFramework; //Include framework

namespace TestFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Framework.working()); //Show working function from class Framework
            Console.ReadKey(); //Readkey so console window doesn't close immediately
        }
    }
}
