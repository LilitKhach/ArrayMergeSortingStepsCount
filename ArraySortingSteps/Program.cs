using System;

namespace ArraySortingSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort sort = new MergeSort();
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            MergeSort.PrintArray(arr);
            sort.Sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            MergeSort.PrintArray(arr);

            var count = sort.CountSteps();
            Console.WriteLine($"Number of steps taken to sort an array: {count}");
        }


    }


}
