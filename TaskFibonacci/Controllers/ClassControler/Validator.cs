using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFibonacci.Controllers.ClassControler
{
    class Validator
    {
        public bool TryParsing(string numberInString)
        {
            return long.TryParse(numberInString, out _);
        }
    }
}
