using System;
using System.Runtime.InteropServices;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            int curr = 1;
            bool isBigger = false;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (curr > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(curr + " ");
                    curr++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}