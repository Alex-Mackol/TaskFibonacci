using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFibonacci.Models.ClassModel
{
    class Fibonacci: IEnumerable
    {
        const long FIRST_NUMBER = 0;
        const long SECOND_NUMBER = 1;

        public long StartNumInDiapazon { get; }
        public long LastNumInDiapazon { get; }

        public Fibonacci(long start, long last)
        {
            StartNumInDiapazon = start;
            LastNumInDiapazon = last;
        }
        private (long,long) FindFirstNumberInRange()
        {
            long currentFirstNumber = 0;
            long previousNumber1 = FIRST_NUMBER;
            long previousNumber2 = SECOND_NUMBER;
            if (StartNumInDiapazon != 0)
            {
                while (StartNumInDiapazon >= previousNumber1)
                {
                    currentFirstNumber = previousNumber1 + previousNumber2;
                    previousNumber1 = previousNumber2;
                    previousNumber2 = currentFirstNumber;
                }
                return (currentFirstNumber, previousNumber1);
            }
            else
            {
                return (SECOND_NUMBER, FIRST_NUMBER);
            }
        }

        public IEnumerator GetEnumerator()
        {
            var (currentFirstNumber, previousNumber1) = FindFirstNumberInRange();
            long previousNumber2 = currentFirstNumber;

            while (previousNumber1 <= LastNumInDiapazon)
            {
                yield return previousNumber1;

                currentFirstNumber = previousNumber1 + previousNumber2;
                previousNumber1 = previousNumber2;
                previousNumber2 = currentFirstNumber;

            }
        }
    }
}
