using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int evenSum = 0, oddSum = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                string currNum = i.ToString();
                for (int j = 0; j < currNum.Length; j++)
                {
                    int currDigit = int.Parse(currNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += currDigit;
                    }
                    else
                    {
                        oddSum += currDigit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    evenSum = 0;
                    oddSum = 0;
                }
            }
        }
    }
}
