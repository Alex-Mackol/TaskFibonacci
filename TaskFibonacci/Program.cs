using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskFibonacci.Controllers.ClassControler;

namespace TaskFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciController fibonacciController = new FibonacciController();
            fibonacciController.StartProgram(args);
            Console.ReadKey();
        }
    }
}
