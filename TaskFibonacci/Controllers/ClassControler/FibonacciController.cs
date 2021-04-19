using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFibonacci.Models.ClassModel;
using TaskFibonacci.View.ClassView;

namespace TaskFibonacci.Controllers.ClassControler
{
    class FibonacciController
    {

        public void StartProgram(string[] args)
        {
            Validator validator = new Validator();
            DisplayElements displayText= new DisplayElements();
            
            if (validator.TryParsing(args[0]) && validator.TryParsing(args[1]))
            {
                Fibonacci fibonacci = new Fibonacci(long.Parse(args[0]), long.Parse(args[1]));
                foreach (long num in fibonacci)
                {
                    displayText.DisplayNumbers(num.ToString());
                }
            }
            else
            {
                displayText.DisplayNumbers("Numbers aren`t validated!");
            }
        }
    }
}
