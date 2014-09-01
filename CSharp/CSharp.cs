using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    public class CSharp
    {
        public int fibonacciRecursivo(int n)
        {
            if (n < 2)
                return n;
            else
                return fibonacciRecursivo(n - 1) + fibonacciRecursivo(n - 2);
        }

        public int fibonacciIterativo(int n)
        {
            int prev = -1;
            int result = 1;
            int sum;
            int i;
            prev = -1;
            result = 1;
            for (i = 0; i <= n; ++i)
            {
                sum = result + prev;
                prev = result;
                result = sum;
            }
            return result;
        }
    }
}
