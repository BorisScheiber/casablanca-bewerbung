﻿using System;
using System.Linq;

namespace MergeSortProject
{
    public class MergeSortExample
    {
        static void Main()
        {
            int[] numbers = { 5, 3, 8, 1, 2, 7 };
            int[] sortedNumbers = MergeSort(numbers);

            Console.WriteLine("Sorted Numbers:");
            Console.WriteLine(string.Join(", ", sortedNumbers));
        }

        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int mid = array.Length / 2;
            int[] left = MergeSort(array.Take(mid).ToArray());
            int[] right = MergeSort(array.Skip(mid).ToArray());

            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
                result[k++] = left[i++];

            while (j < right.Length)
                result[k++] = right[j++];

            return result;
        }
    }
}
