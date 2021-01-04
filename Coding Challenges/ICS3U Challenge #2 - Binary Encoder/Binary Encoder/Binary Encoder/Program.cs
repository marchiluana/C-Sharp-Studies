using System;
using System.IO;

namespace Binary_Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input thaty.txt");
            StreamWriter writer = new StreamWriter("output thaty.txt");

            string phrase = reader.ReadLine();
            
            char[] chars = phrase.ToCharArray();
            Console.WriteLine("Original string: {0}",phrase);
            Console.WriteLine("Character array:");
            writer.WriteLine("{0, -9} {1, -9} {2, -9}", "CHAR", "ASCII", "BINARY");
            writer.WriteLine("------------------------------");
            writer.WriteLine();

            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                int ascii = (int)chars[ctr];
                Console.WriteLine("   {0}: {1}", chars[ctr], ascii);
                string binary = asciiToBinary(ascii);
                if (binary.Length < 8)
                {
                    int numofzeros = 0;
                    numofzeros = 8 - binary.Length;
                    for (int i = 0; i < numofzeros; i++)
                    {
                        binary = "0" + binary;
                    }
                }
                writer.WriteLine("{0, -9} {1, -9} {2, -9}", chars[ctr], ascii, binary);
            }

            reader.Close();
            writer.Close();

        }
        public static string asciiToBinary (int ascii)
        {
            string result = string.Empty;
            while (ascii > 0)
            {
                int remainder = ascii % 2;
                ascii = ascii / 2;
                result = remainder.ToString() + result;
            }
            return result;

        }
    }
}
