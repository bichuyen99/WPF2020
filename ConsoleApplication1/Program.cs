using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void bubblesort (int []arr)
        {
            int n = arr.Length;
            for (int i=0; i<n-1; i++)
                for (int j =0; j< n-i-1; j++)
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
        static void printArray(int[]arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public static void Main()
        {
            int[] arr = { 1, 9, 5, 3, 4 };
            bubblesort(arr);
            Console.WriteLine("Sort");
            printArray(arr);
        }
    }
}
