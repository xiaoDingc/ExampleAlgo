using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTest
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime dt=DateTime.Now;
            Console.WriteLine(dt.ToString("MM/dd"));
            int[] a=new []{1,2,13,4,5,6};
            Array.Sort(a);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
