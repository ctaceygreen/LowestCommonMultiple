using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int N, int M)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        //Chocolates problem is simply the Lowest Common Multiple of N and M, divided by M.
        return (int)(LowestCommonMultiple(N, M) / M);
    }

    /// <summary>
    /// Lowerst common multiple is lcm(a,b) = (a*b) / (gcd(a,b))
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public long LowestCommonMultiple(long n, long m)
    {
        return (n * m) / GreatestCommonDivisior(n, m);
    }

    public long GreatestCommonDivisior(long a, long b)
    {
        return GreatestCommonDivisior(a, b, 1);
    }
    public long GreatestCommonDivisior(long a, long b, long res)
    {
        if (a == b)
            return res * a;
        else if ((a % 2 == 0) && (b % 2 == 0))
            return GreatestCommonDivisior(a / 2, b / 2, 2 * res);
        else if (a % 2 == 0)
            return GreatestCommonDivisior(a / 2, b, res);
        else if (b % 2 == 0)
            return GreatestCommonDivisior(a, b / 2, res);
        else if (a > b)
            return GreatestCommonDivisior(a - b, b, res);
        else
            return GreatestCommonDivisior(a, b - a, res);
    }
}