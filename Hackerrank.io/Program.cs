using System;
using System.Collections.Generic;

namespace Hackerrank.io
{
    class Program
    {
        protected static int SequentialSearch(int[] flag, int e)
        {
            var arrayLength = flag.Length;
            var index = 0;
            do
            {
                index++;
            } while (index < flag.Length && flag[index] != e);
            if (index < arrayLength)
            {
                return index;
            }

            return -1;
        }

        protected static int BinarySearch(int[] flag, int e)
        {
            //Diviser pour mieux regner
            var leftSide = 0;
            var rightSide = flag.Length;
            var index = (rightSide + leftSide) / 2;
            do
            {
                if (e < flag[index])
                {
                    rightSide = index - 1;
                }
                else
                {
                    leftSide = index + 1;
                }
                index = (rightSide + leftSide) / 2;
            } while (e != flag[index] && leftSide <= rightSide);

            if (e == flag[index])
            {
                return index;
            }
            return -1;
        }

        private static int Partition(int[] myArray, int leftSide, int rightSide)
        {
            int pivot = myArray[rightSide];
            int i = leftSide - 1;
            for (int j = leftSide; j < rightSide; j++)
            {
                if (myArray[j] <= pivot)
                {
                    i++;
                    int tmp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = tmp;
                }
            }
            int index = i + 1;
            int flag = myArray[index];
            myArray[index] = myArray[rightSide];
            myArray[rightSide] = flag;

            return index;
        }

        protected static int[] QuickSort(int[] myArray, int leftSide, int rightSide)
        {
            if (leftSide < rightSide)
            {
                int pivot = Partition(myArray, leftSide, rightSide);
                QuickSort(myArray, leftSide, pivot - 1);
                QuickSort(myArray, pivot + 1, rightSide);
            }

            return myArray;
        }

        public static int GetMatchedCouples(int[] myArray, int n, int k)
        {
            int count = 0;
            for (var i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if ((myArray[i] + myArray[j]) / k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static Tuple<DateTime, DateTime> GetDay(DateTime currentDate)
        {
            var map = new Dictionary<System.DayOfWeek, Tuple<DateTime, DateTime>>()
            {
                {System.DayOfWeek.Monday, new Tuple<DateTime, DateTime>(currentDate, currentDate.AddDays(6)) },
                {System.DayOfWeek.Tuesday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-1), currentDate.AddDays(5)) },
                {System.DayOfWeek.Wednesday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-2), currentDate.AddDays(4))},
                {System.DayOfWeek.Thursday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-3), currentDate.AddDays(3)) },
                {System.DayOfWeek.Friday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-4), currentDate.AddDays(2)) },
                {System.DayOfWeek.Saturday,  new Tuple<DateTime, DateTime>(currentDate.AddDays(-5), currentDate.AddDays(1)) },
                {System.DayOfWeek.Sunday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-6), currentDate) },
            };
            Tuple<DateTime, DateTime> output;
            map.TryGetValue(currentDate.DayOfWeek, out output);
            return output;
        }

        static void Main(string[] args)
        {
            int[] myArray = new[] {10, 20, 20, 10, 10, 30, 50, 10, 20};

            Console.ReadKey();
        }
    }
}
