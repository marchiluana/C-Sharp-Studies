using System;
using System.IO;

namespace _3D_Shape_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");

            int numCubes = 0;
            int numSpheres = 0;
            int numPyramids = 0;

            double cubeCost = 0;
            double sphereCost = 0;
            double pyramidCost = 0;

            double costPerCC = double.Parse(reader.ReadLine());
            const double PI = 3.14;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');
                
                string shape = parts[0];
                if (shape == "cube")
                {
                    int l = int.Parse(parts[1]);
                    int v = l * l * l;
                    numCubes++;
                    double cost = v * costPerCC;
                    cubeCost += cost;
                }

                else if (shape == "sphere")
                {
                    int r = int.Parse(parts[1]);
                    double V = 4d/3d * PI * r * r * r;
                    numSpheres++;
                    double cost = V * costPerCC;
                    sphereCost += cost;

                }

                else if (shape == "pyramid")
                {
                    int l = int.Parse(parts[1]);
                    int h = int.Parse(parts[2]);
                    int v = l * l * h / 3;
                    numPyramids++;
                    double cost = v * costPerCC;
                    pyramidCost += cost;

                }
            }
            int totalNum = numCubes + numSpheres + numPyramids;
            double totalCost = pyramidCost + cubeCost + sphereCost;

            writer.WriteLine("------------------------------------------");
            writer.WriteLine("| {0, -15}| {1, -10}| {2, -10}|", "SHAPE", "COUNT", "COST");
            writer.WriteLine("------------------------------------------");
            writer.WriteLine("| {0, -15}| {1, -10}| {2, -10}|", "cube", numCubes, cubeCost.ToString("C"));
            writer.WriteLine("------------------------------------------");
            writer.WriteLine("| {0, -15}| {1, -10}| {2, -10}|", "sphere", numSpheres, sphereCost.ToString("C"));
            writer.WriteLine("------------------------------------------");
            writer.WriteLine("| {0, -15}| {1, -10}| {2, -10}|", "pyramid", numPyramids, pyramidCost.ToString("C"));
            writer.WriteLine("------------------------------------------");
            writer.WriteLine("| {0, -15}| {1, -10}| {2, -10}|", "TOTAL", totalNum, totalCost.ToString("C"));
            writer.WriteLine("------------------------------------------");

            reader.Close();
            writer.Close();

        }
    }
}

