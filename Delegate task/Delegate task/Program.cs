using System;

namespace Delegate_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] PruductPrices = { 1.5, 20.7, 7.99, 4.1, 100.98, 12.5 };
            Action<double[]> FullInfo = FindTotalPriceAndCount;
            FullInfo(PruductPrices);

        }
        public static void FindTotalPriceAndCount(double[] Arr)
        {
            int count = Arr.Length;
            double TotalPrice = default(int);
            foreach (double item in Arr)
            {
                TotalPrice += item;
            }
            Console.WriteLine($"Total price of pruduct: {TotalPrice}$ , Pruducts count: {count}");
        }
    }
}
