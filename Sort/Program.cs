using System;
using System.IO;
using System.Diagnostics;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Десять эл. заполненных вручную.
            int[] x = { 89, 23, 53, 12, 78, 18, 57, 91, 21, 84 };
            using (StreamWriter writer = new StreamWriter("Test.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    writer.Write(x[i] + " ");
                }
                writer.WriteLine();
                Sort.Distribute(x);
                for (int i = 0; i < 10; i++)
                {
                    writer.Write(x[i] + " ");
                } 
            }

            //100000 эл. заполненных рандомно со 
            //со снятием временных показателей
            int n = 100000;
            int[] y = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                y[i] = random.Next(10, 100);
            }
            Stopwatch time = new Stopwatch();
            using (StreamWriter Write = new StreamWriter("Test10000.txt"))
            {
                Write.WriteLine("Distribute sort of 10000 rand elements");
                time.Start();
                Sort.Distribute(y, n);
                time.Stop();
                Write.WriteLine(time.ElapsedMilliseconds + " milli seconds");
            }

            Console.WriteLine("Ready");
            Console.ReadKey();
        }
    }
}
