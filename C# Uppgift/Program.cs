using System;

namespace C__Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();

        int[] arr = new int[1000];
        int n = 1000;
        Console.WriteLine("Selection sort");
        Console.Write("Initial array is: ");
        for (int i = 0; i < n; i++) {
        Console.Write(arr[i] + " ");
        }
        int temp, smallest;
        for (int i = 0; i < n - 1; i++) {
         smallest = i;
         for (int j = i + 1; j < n; j++) {
            if (arr[j] < arr[smallest]) {
               smallest = j;
            }
         }
         temp = arr[smallest];
         arr[smallest] = arr[i];
         arr[i] = temp;
      }
        Console.WriteLine();
        Console.Write("Sorted array is: ");
        for (int i = 0; i < n; i++) {
        Console.Write(arr[i] + " ");
        watch.Stop();
        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
      }
   }
 }
}