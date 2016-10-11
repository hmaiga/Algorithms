using System;
using System.Collections.Generic;

namespace Hackerrank.io
{
    public class Hackerrank
    {
        public int SequentialSearch(int[] flag, int e)
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

        public int BinarySearch(int[] flag, int e)
        {
            //Diviser pour mieux regner
            var leftSide = 0;
            var rightSide = flag.Length;
            var index = (rightSide + leftSide)/2;
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
                index = (rightSide + leftSide)/2;
            } while (e != flag[index] && leftSide <= rightSide);

            if (e == flag[index])
            {
                return index;
            }
            return -1;
        }

        public int Partition(int[] myArray, int leftSide, int rightSide)
        {
            var pivot = myArray[rightSide];
            var i = leftSide - 1;
            for (var j = leftSide; j < rightSide; j++)
            {
                if (myArray[j] <= pivot)
                {
                    i++;
                    var tmp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = tmp;
                }
            }
            var index = i + 1;
            var flag = myArray[index];
            myArray[index] = myArray[rightSide];
            myArray[rightSide] = flag;

            return index;
        }

        public int[] QuickSort(int[] myArray, int leftSide, int rightSide)
        {
            if (leftSide < rightSide)
            {
                var pivot = Partition(myArray, leftSide, rightSide);
                QuickSort(myArray, leftSide, pivot - 1);
                QuickSort(myArray, pivot + 1, rightSide);
            }

            return myArray;
        }

        public int GetMatchedCouples(int[] myArray, int n, int k)
        {
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = i; j < n; j++)
                {
                    if ((myArray[i] + myArray[j])/k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public Tuple<DateTime, DateTime> GetDay(DateTime currentDate)
        {
            var map = new Dictionary<DayOfWeek, Tuple<DateTime, DateTime>>
            {
                {DayOfWeek.Monday, new Tuple<DateTime, DateTime>(currentDate, currentDate.AddDays(6))},
                {DayOfWeek.Tuesday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-1), currentDate.AddDays(5))},
                {DayOfWeek.Wednesday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-2), currentDate.AddDays(4))},
                {DayOfWeek.Thursday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-3), currentDate.AddDays(3))},
                {DayOfWeek.Friday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-4), currentDate.AddDays(2))},
                {DayOfWeek.Saturday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-5), currentDate.AddDays(1))},
                {DayOfWeek.Sunday, new Tuple<DateTime, DateTime>(currentDate.AddDays(-6), currentDate)}
            };
            Tuple<DateTime, DateTime> output;
            map.TryGetValue(currentDate.DayOfWeek, out output);
            return output;
        }

        public int[] CompareTriple(string[] arg1, string[] arg2)
        {
            var scores = new int[2];
            var aliceScore = 0;
            var bobScore = 0;
            for (var i = 0; i < arg1.Length && i < arg2.Length; i++)
            {
                if (Convert.ToInt32(arg1[i]) == Convert.ToInt32(arg2[i]))
                    continue;

                if (Convert.ToInt32(arg1[i]) > Convert.ToInt32(arg2[i]))
                    scores[0] = ++aliceScore;
                else
                    scores[0] = ++aliceScore;
            }
            return scores;
        }

        public void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        //Custom BubbleSort
        private Tuple<int[], int> BubbleSort(int[] myArray, int arrayLenght)
        {
            var countSwaping = 0;
            for (var i = 0; i < arrayLenght; i++)
            {
                for (var j = 0; j < arrayLenght - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        Swap(ref myArray[j], ref myArray[j + 1]);
                        countSwaping++;
                    }
                }
                if (countSwaping == 0)
                {
                    break;
                }
            }
            return new Tuple<int[], int>(myArray, countSwaping);
        }
    }
}