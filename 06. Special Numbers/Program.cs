using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i < 9999; i++)
            {
                string convChar = i.ToString();
                int currDigit1 = int.Parse(convChar[0].ToString());
                int currDigit2 = int.Parse(convChar[1].ToString());
                int currDigit3 = int.Parse(convChar[2].ToString());
                int currDigit4 = int.Parse(convChar[3].ToString());
                if (currDigit1 != 0 && currDigit2 != 0 && currDigit3 != 0 && currDigit4 != 0)
                {
                    if (n % currDigit1 == 0 && n % currDigit2 == 0 && n % currDigit3 == 0 && n % currDigit4 == 0)
                    {
                        Console.Write(convChar + " ");
                    }
                }
            }

        }
    }
}