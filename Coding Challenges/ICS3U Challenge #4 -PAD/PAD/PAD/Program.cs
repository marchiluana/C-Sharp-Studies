using System;
using System.IO;

namespace PAD
{
    class Program
    {
        static void Main(string[] args)C:\Users\lunal\Documents\Escola\Programação\Coding Challenges\ICS3U Challenge #4 -PAD\PAD\PAD\Program.cs
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            int[] perfect = new int[1000];
            int[] abundant = new int[1000];
            int[] deficient = new int[1000];

            reader.ReadLine();
            int p = 0;
            int a = 0;
            int d = 0;

            while (!reader.EndOfStream)
            {
                int n = int.Parse(reader.ReadLine());

                int sum = 0;

                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == n)
                {
                    p++;
                    perfect[p] += n;
                }
                else if (sum > n)
                {
                    a++;
                    abundant[a] += n;
                }
                else
                {
                    d++;
                    deficient[d] += n;
                }
            }

            int[] sortedPerfect = BubbleSort(perfect);
            int[] sortedAbundant = BubbleSort(abundant);
            int[] sortedDeficient = BubbleSort(deficient);


            writer.WriteLine("PERFECT NUMBERS");
            for (int i = 0; i < sortedPerfect.Length; i++)
            {
                if (perfect[i] > 0)
                {
                    writer.WriteLine(sortedPerfect[i]);
                }
            }
            writer.WriteLine("");
            writer.WriteLine("ABUNDANT NUMBERS");
            for (int i = 0; i < sortedAbundant.Length; i++)
            {
                if (abundant[i] > 0)
                {
                    writer.WriteLine(sortedAbundant[i]);
                }
            }
            writer.WriteLine("");
            writer.WriteLine("DEFICIENT NUMBERS");
            for (int i = 0; i < sortedDeficient.Length; i++)
            {
                if (deficient[i] > 0)
                {
                    writer.WriteLine(sortedDeficient[i]);
                }
            }
            reader.Close();
            writer.Close();

        }

        static int[] BubbleSort(int[] array)
        {
            int length = array.Length;

            int temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
        