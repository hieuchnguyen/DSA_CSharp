using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02Recursion
{
    class Program
    {
        // https://ideone.com/Bo4Bkp
        static long factorial(int n)
        {
            if (n <= 1)
                return 1;            
            return n * factorial(n - 1);
        }

        static int gcd(int m, int n)
        {
            int r = m % n;
            if (r == 0) 
                return n;
            return gcd(n, r);
        }

        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(factorial(n)); // 1 * 2 * 3 = 6

            Console.WriteLine(gcd(15, 45));
        }
    }
}
