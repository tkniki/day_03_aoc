using System;
using System.IO;

namespace day_03
{
    class Program
    {
        //part 1:
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

        //part: 2

        static string[] FindMostCommonBits (string[] arr)
        {
            int binaryLength = arr[0].Length;
            string[] mostCommonBits = new string[binaryLength];
            for (int i = 0; i < binaryLength; i++)
            {
                mostCommonBits[i] = FindMostCommonBit(arr, i).ToString();
            }

            return mostCommonBits;
        }

        /*static void O2GenAndCO2Gen (string[] arr)
        {
            int binaryLength = arr[0].Length;
            char[] mostCommonBit = new char[binaryLength];
            for (int i = 0; i < binaryLength; i++)
            {
                mostCommonBit[binaryLength] = FindMostCommonBit(arr, i);

            }


            for (int i = 0; i < mostCommonBit.Length; i++)
            {
                Console.WriteLine(mostCommonBit[i]);
            }
           
        }*/
        /*static string O2GenAndCO2Gen(string[] arr, char bit)
        {
            for (int i = 0; i < arr[0].Length; i++)
            {

            }
        }*/

        static void Main(string[] args)
        {
            string[] DiagnosticReport = new string[12];
            StreamReader file = new StreamReader("example.txt");

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

            /*Console.WriteLine($"binary gamma: {binaryGammaRate}, binary epsilon: {binaryEpsilonRate}");
            Console.WriteLine($"decimal gamma: {gammaRate}, decimal epsilon: {epsilonRate}");

            Console.WriteLine(gammaRate * epsilonRate);*/

            for (int i = 0; i < DiagnosticReport[0].Length; i++)
            {
                Console.WriteLine(FindMostCommonBits(DiagnosticReport)[i]);
            }
        }
    }
}
