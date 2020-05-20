using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_17
{
    class Class1
    {
        int number;
        public Class1() { }
        public Class1(int number)
        {
            this.number = number;
        }

        public int Convert_To_Ten()
        {
            int result, n;
            result = n = 0;
            while(number != 0)
            {
                result += (number % 10) * (int)Math.Pow(2, n);
                n += 1;
                number %= 10;
            }
            return result;
        }
    }
}
