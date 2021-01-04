using System;
using System.IO;
using System.Collections.Generic;

namespace Bling_Frames
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");

            List<string> messages = new List<string>();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine().Trim();

                if (line == "<")
                {
                    messages.Clear();
                }
                else if (line == ">")
                {
                    int longestLength = findLongestLength(messages);

                    int frameWidth = 0;
                    if (longestLength % 2 == 0)
                    {
                        frameWidth = longestLength + 6;
                    }

                    else
                    {
                        frameWidth = longestLength + 7;
                    }

                    writer.WriteLine(repeat(frameWidth, '$'));
                    foreach (string mike in messages)
                    {
                        writer.Write("$  ");
                        int indent = calculateIndent(longestLength, mike.Length);
                        writer.Write(repeat(indent, ' '));
                        writer.Write(mike);
                        writer.Write(repeat(frameWidth - (3 + indent + mike.Length + 3), ' '));
                        writer.WriteLine("  $");
                    }
                    writer.WriteLine(repeat(frameWidth, '$'));
                    writer.WriteLine();
                }
                else
                {
                    messages.Add(line);
                }
            }
            writer.Close();
            reader.Close();
        }

        static string repeat(int n, char c)
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += c;
            }
            return s;
        }
        static int findLongestLength(List<string> message)
        {
            int longestLength = 0;
            foreach (string line in message)
            {
                if (line.Length > longestLength)
                {
                    longestLength = line.Length;
                }
            }
            return longestLength;
        }

        static int calculateIndent(int longestLength, int lineLength)
        {
            int indent = 0;
            if (longestLength % 2 == 0)
            {
                indent = (longestLength - lineLength) / 2;
            }
            else
            {
                indent = (longestLength - lineLength + 1) / 2;
            }
            return indent; 
        }
    }
}





