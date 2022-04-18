using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Assignment
{
    //[MemoryDiagnoser]
    //[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    //[RankColumn]
    public static class SortingManager
    {
        public static int[] InsertionSort(int[] arr)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("Total process duration for Insertion Sort :{0}", sw.Elapsed.TotalMilliseconds + "ms");
            return arr;
        }

        public static List<int> MergeSort(List<int> arrList)
        {
            if (arrList.Count <= 1)
                return arrList;

            var leftSide = new List<int>();
            var rightSide = new List<int>();

            int middle = arrList.Count / 2;
            for (int i = 0; i < middle; i++) //Divide from middle and push for the leftside arr
            {
                leftSide.Add(arrList[i]);
            }
            for (int i = middle; i < arrList.Count; i++)//Divide from middle and push for the right side arr
            {
                rightSide.Add(arrList[i]);
            }

            leftSide = MergeSort(leftSide);
            rightSide = MergeSort(rightSide);
            return Merge(leftSide, rightSide);
        }

        private static List<int> Merge(List<int> leftSide, List<int> rightSide)
        {
            List<int> result = new List<int>();

            while (leftSide.Count > 0 || rightSide.Count > 0)
            {
                if (leftSide.Count > 0 && rightSide.Count > 0)
                {
                    if (leftSide.First() <= rightSide.First()) //Compare elements to order smaller to bigger
                    {
                        result.Add(leftSide.First());
                        leftSide.Remove(leftSide.First()); //Remove sorted items from the actual list.
                    }
                    else
                    {
                        result.Add(rightSide.First());
                        rightSide.Remove(rightSide.First());
                    }
                }
                else if (leftSide.Count > 0)
                {
                    result.Add(leftSide.First());
                    leftSide.Remove(leftSide.First());
                }
                else if (rightSide.Count > 0)
                {
                    result.Add(rightSide.First());

                    rightSide.Remove(rightSide.First());
                }
            }
            return result;
        }

        public static int[] CreateRandomArray(int count)
        {
            Random random = new Random();
            int[] values = new int[count];

            for (int i = 0; i < count; ++i)
                values[i] = random.Next(0, 100);

            return values;
        }    
    }
}
