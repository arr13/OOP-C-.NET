using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2___3b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            SortUtils sortUtils = new SortUtils();
            sortUtils.InItArray(arr);
            sortUtils.PrintArray(arr);

            sortUtils.SortArray(arr);
            Console.WriteLine();
            sortUtils.PrintArray(arr);
            Console.WriteLine();

            int[] arr2 = new int[5];
            sortUtils.InItArray(arr2);

            int[] arr_merged = sortUtils.Merge(arr, arr2);
            sortUtils.PrintArray(arr_merged);
        }

        
    }
}
