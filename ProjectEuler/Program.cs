using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    internal class Program
    {
        private static void Multiple(int n)
        {
            var count = 0;
            for (var i = 1; i < n + 1; i++)
            {
                if (i%3 == 0 || i%5 == 0 && i%15 != 0)
                {
                    count += i;
                }
            }
            Console.WriteLine(count - n);
        }

        private static int Fibonacci(int n)
        {
            if (n < 0 || n > 46)
            {
                throw new ArgumentException();
            }
            if (n == 1 || n == 2)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private static double LargestPrimeFactor(double n)
        {
            //int primeFactor = 2;
            //n=28
            for (var i = 2; i < Math.Sqrt(n); i++)
            {
                while (n%i == 0)
                {
                    n = n/2;
                }
            }

            return n;
        }

        private static void PrimeFactor(long n)
        {
            var q = Math.Ceiling(Math.Sqrt(n));
            var a = q + 1;
            double b = 0;
            var bCarre = Math.Pow(a, 2) - n;
            var deuxAplusUn = 2*a + 1;
            var cpt = 0;
            while (Math.Abs(Math.Pow((int) Math.Sqrt(bCarre), 2) - bCarre) != 0)
            {
                bCarre += deuxAplusUn;
                deuxAplusUn = deuxAplusUn + 2;
                a++;
                cpt++;
            }
            b = Math.Sqrt(bCarre);
            Console.WriteLine($"Le nombre {n} est le produit de {a + b} par {a - b}.");
            Console.WriteLine($"Et il a fallu {cpt} étapes pour le factoriser.");
        }

        private static Tuple<double, double> SumSquareDifference(int n)
        {
            //25164150
            double counter = 0;
            double optimizeCounter = 0;
            double sumSquare = 0;
            double squareSum = 0;
            for (var i = 1; i <= n; i++)
            {
                sumSquare += Math.Pow(i, 2);
                //Console.WriteLine(Math.Pow(i, 2));
                squareSum += i;
                //Console.WriteLine(squareSum);
            }
            counter = Math.Pow(squareSum, 2) - sumSquare;
            optimizeCounter = Math.Pow(n, 2)*Math.Pow(n + 1, 2)*1/4 + n*(n + 1)*(2*n + 1)*1/6;
            return new Tuple<double, double>(counter, optimizeCounter);
        }

        private static double SmallestMultiple(int n)
        {
            double counter = 0;
            var x = 0;
            for (var i = 1; i <= x++; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    if (x%j == 0)
                    {
                        counter = x;
                    }
                }
            }
            return counter;
        }

        public static int[] GeneratePrime(int limit)
        {
            var primes = new List<int>();
            bool isPrime;
            var j = 0;

            primes.Add(2);
            for (var i = 3; i <= limit; i++)
            {
                j = 0;
                isPrime = true;
                while (Math.Pow(primes[j], 2) <= i)
                {
                    if (i%primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes.ToArray<int>();
        }

        private static double SmallestPrimeFactor(int n)
        {
            var primeFactor = new List<int> {2, 3, 5, 7, 11, 13, 17, 19, 23};
            var stockPrimeFactor = new List<int>();
            double counter = 0;
            for (var i = 2; i <= n; i++)
            {
                //i = 3
                var flag = 0;
                var j = 0;
                while (i >= 2)
                {
                    if (i%2 == 0 && i != 0)
                    {
                        flag = i/2;
                        j++;
                    }
                    else
                    {
                        var casting = i.ToString();
                        for (var k = 0; k < casting.Length; k++)
                        {
                            var x = int.Parse(casting[k].ToString());
                        }
                    }
                }
            }

            return counter;
        }

        private static void Main(string[] args)
        {
        }
    }
}