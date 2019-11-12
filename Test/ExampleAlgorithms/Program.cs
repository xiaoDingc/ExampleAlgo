using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10000;
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = Guid.NewGuid().GetHashCode();
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortHelper<int>.SellSort(a);
            stopwatch.Stop();

            Console.WriteLine(SortHelper<int>.isSorted(a));
            //SelectSort 55325  //insertSort 74299 sell 13
            Console.WriteLine("共耗费时间:" + stopwatch.ElapsedMilliseconds);
            // SortHelper<int>.Show(a);


            Console.ReadKey();
        }
    }
}
