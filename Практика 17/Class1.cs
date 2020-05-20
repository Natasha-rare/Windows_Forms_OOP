using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_17
{

    static class Convertion
    {
        enum sixteen
        {
            A = 10, B, C, D, E, F
        };

        static public int Convert_To_Ten(int number)
        {
            int result, n;
            result = n = 0;

            while (number > 0)
            {
                result += (number % 10) * (int)Math.Pow(2, n);
                n += 1;
                number /= 10;

            }
            return result;
        }

        static public int Convert_To_Eight(int number)
        {
            int result, n, k;
            result = n = 0;
            k = 1; // счётчик итераций
            while (number > 0)
            {
                n = 0;
                for (int i = 0; i < 3; i++)
                {
                    n += (number % 10) * (int)Math.Pow(2, i);
                    number /= 10;
                }
                result = n * k + result;
                k *= 10;
            }

            return result;
        }



        static public string Convert_To_Sixteen(int number)
        {
            int n, k;
            n = 0;
            string result = "";
            while (number > 0)
            {
                n = 0;
                for (int i = 0; i < 4; i++)
                {
                    n += (number % 10) * (int)Math.Pow(2, i);
                    number /= 10;
                }
                if (n > 9)
                {
                    for (sixteen j = sixteen.A; j <= sixteen.F; j++)
                    {
                        if ((int)j == n)
                        {
                            result = Convert.ToString(j) + result;
                        }
                    }
                }
                else result = Convert.ToString(n) + result;
            }

            return result;
        }
    }


}
