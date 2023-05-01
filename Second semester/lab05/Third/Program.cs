﻿namespace Third
{
    internal class Program
    {
        static object lockObject = new object();

        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 7, 5, 1, 3, 6 };

            Console.WriteLine("Original array:");
            PrintArray(arr);

            QuickSort(arr);

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }

        static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                Thread t1 = new Thread(() => QuickSort(arr, left, pivot - 1));
                Thread t2 = new Thread(() => QuickSort(arr, pivot + 1, right));

                t1.Start();
                t2.Start();

                t1.Join();
                t2.Join();
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j <= right - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);

            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            lock (lockObject)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}