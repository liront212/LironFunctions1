using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FunctionExOne.Abstract;

namespace FunctionExOne
{
    public class FunctionExOne1 : IExercise
    {
        public int GetLastDigit(int number)
        {
            return (number % 10);
        }

        public int GetAllButLastDigit(int number)
        {
            if (number < 10)
            {
                return -1;
            }
            return (number / 10);
        }

        public int GetAmountOfDigits(int number)
        {
            int count = 0;
            if (number == 0)
            {
                return 1;
            }
            while (number != 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        public int GetDigintInIndex(int number, int index)
        {
            number = number / (int) Math.Pow (10, index);
            return GetLastDigit(number);
        }
    }
}
