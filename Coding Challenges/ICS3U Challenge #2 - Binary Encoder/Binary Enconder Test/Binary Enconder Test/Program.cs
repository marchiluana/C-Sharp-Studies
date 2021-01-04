using System;

namespace Binary_Enconder_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 1;
            int x = 65;
            int y = 22;
            int z = 2;
            string s = "";

            for (int i = x + 3; i < x + y && i <= 90; i+=z)
            {
                char c;
                if (i % 2 != w )
                {
                    c = (char)i;
                
                }
                else
                {
                    c = '_';
                }
                s += c;
            }
            Console.WriteLine(s);
        }
    }
}
