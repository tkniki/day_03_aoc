using System;
using System.IO;

namespace day_03
{
    class Program
    {
        static char FindMostCommonBit(string[] arr, int index)
        {
            char gammaBit;
            int Zeros = 0;
            int Ones = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i][index] == '0')
                {
                    Zeros++;
                }
                else
                {
                    Ones++;
                }
            }

            if (Zeros > Ones)
            {
                gammaBit = '0';
            }
            else
            {
                gammaBit = '1';
            }

            return gammaBit;
        }

        static string IterateThroughBinLength(string[] arr)
        {
            string gammaRate = "nothing";
            for (int index = 0; index < arr[0].Length; index++)
            {
                if (index == 0)
                {
                    gammaRate = FindMostCommonBit(arr, index).ToString();
                }
                else
                {
                    gammaRate += FindMostCommonBit(arr, index).ToString();
                }
            }

            return gammaRate;
        }

        static void Main(string[] args)
        {
            string[] DiagnosticReport = new string[1000];
            StreamReader file = new StreamReader("input.txt");

            for (int i = 0; i < DiagnosticReport.Length; i++)
            {
                DiagnosticReport[i] = file.ReadLine();
            }

            string binaryGammaRate = IterateThroughBinLength(DiagnosticReport);
            int gammaRate = Convert.ToInt32(binaryGammaRate, 2);
           // Console.WriteLine(gammaRate);

            string binaryEpsilonRate = "";

            for (int i = 0; i < binaryGammaRate.Length; i++)
            {
                
                if (binaryGammaRate[i] == '0')
                {
                    binaryEpsilonRate += "1";
                }
                else
                {
                    binaryEpsilonRate += "0";
                }
            }


            int epsilonRate = Convert.ToInt32(binaryEpsilonRate, 2);
            //Console.WriteLine(epsilonRate);


            /*char a = '0';
            char b = '1';
            string ab = a.ToString() + b.ToString();
            Console.WriteLine(ab);*/

            /*for (int i = 0; i < DiagnosticReport.Length; i++)
            {
                Console.WriteLine(DiagnosticReport[i]);
            }*/

            Console.WriteLine($"binary gamma: {binaryGammaRate}, binary epsilon: {binaryEpsilonRate}");
            Console.WriteLine($"decimal gamma: {gammaRate}, decimal epsilon: {epsilonRate}");

            Console.WriteLine(gammaRate * epsilonRate);
        }
    }
}
