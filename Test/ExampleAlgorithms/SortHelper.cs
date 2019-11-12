using System;

namespace ExampleAlgorithms
{
    public static class SortHelper<T> where T : IComparable
    {

        //选择排序
        public static void SelectSort(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min = i;
                int N = a.Length;
                for (int j = i + 1; j < N; j++)
                {
                    //比较两个值的大小
                    if (less(a[j], a[min]))
                    {
                        min = j;
                    }
                }
                exch(a, i, min);
            }
        }
        //插入排序
        public static void InsertSort(T[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = i; j > 0 && less(a[j], a[j - 1]); j--)
                {
                    exch(a, j, j - 1);
                }
            }
        }

        //希尔排序
        public static void SellSort(T[] a)
        {
            int h = 1;
            while (h < a.Length / 3)
            {
                h = h * 3 + 1;
            }
            while (h >= 1)
            {
                for (int i = h; i < a.Length; i++)
                {
                    for (int j = h; j > 0 && less(a[j], a[j - h]); j = j - h)
                    {
                        exch(a, j, j - h);
                    }
                }
                h = h / 3;
            }
        }

        public static Boolean greater(T v, T w)
        {
            return v.CompareTo(w) >= 0;
        }

        private static Boolean less(T v, T w)
        {
            return v.CompareTo(w) <= 0;
        }
        private static void exch(T[] a, int i, int j)
        {
            T t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
        public static void Show(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            // Console.ReadKey();
        }
        public static Boolean isSorted(T[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (less(a[i - 1], a[i]))
                {
                    return true;
                }

            }
            return false;
        }
    }
}