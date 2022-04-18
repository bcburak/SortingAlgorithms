using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your sorting algorithm: \n 1. Insertion \n 2.Merge \n ");
            var algoType = Console.ReadLine();
            Console.Write("Enter array count: \n ");
            var arrayCount = Console.ReadLine();

            var arr = SortingManager.CreateRandomArray(Convert.ToInt32(arrayCount));
            PrintList(arr.ToList<int>());


            if (Convert.ToInt32(algoType) == (int)SortingEnum.InsertionSort) //Insertion Sort
            {
                var insertionSorted = SortingManager.InsertionSort(arr);
                PrintList(insertionSorted.ToList<int>());

            }
            else if(Convert.ToInt32(algoType) == (int)SortingEnum.MergeSort) // MergeSort
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var mergeSortedList = SortingManager.MergeSort(arr.ToList<int>());
                sw.Stop();
                Console.WriteLine("Total process duration for Merge Sort :{0}", sw.Elapsed.TotalMilliseconds + "ms");

                PrintList(mergeSortedList);
            }
            else
            {
                Console.WriteLine("Please choose one of actual sorting algorithm");
            }          
        }     

        private static void PrintList(List<int> arr)
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
