using System;

namespace Sorting_BubbleSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] unSortedDate = { 20, 35, -15, -15, 7, 55, 1, -22 };
            var first = $"[{string.Join(", ", unSortedDate)}]";
            Console.WriteLine("unsorted      :   " + first);
            for (int lastUnSortedIndex = unSortedDate.Length - 1;
                lastUnSortedIndex > 0;
                lastUnSortedIndex--)
            {
                for (int i = 0; i < lastUnSortedIndex; i++)
                {
                    if (unSortedDate[i] > unSortedDate[i + 1])
                    {
                        Swap(unSortedDate, i, i + 1);
                    }
                }
            }

            var sortedData = unSortedDate;
            var sorted = $"[{string.Join(", ", sortedData)}]";
            Console.WriteLine("sorted     :   " + sorted);
            Console.ReadLine();
        }

        /// <summary>
        /// implement a swap function
        /// </summary>
        /// <param name="arrays"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private static void Swap(int[] data, int firstIndex, int secondIndex)
        {
            if (firstIndex == secondIndex)
            {
                return;
            }

            var temperalStorage = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temperalStorage;
        }
    }
}