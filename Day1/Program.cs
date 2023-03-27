using System;
using System.IO;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        part1();

        
    }

    static void part1()
    {
        string path = @"D:\visual_studio_code_knowe_traing\Advent_Of_Code_2022\Day1\data.txt";
        string[] data = File.ReadLines(path).ToArray();

        int sum = 0;
        int max = 0;

        foreach(string line in data)
        {
            if(string.IsNullOrEmpty(line))
            {
                if(sum > max)
                    max = sum;
                sum = 0;
            }
            else
                sum += int.Parse(line);
        }
        Console.WriteLine(max);
        
    }

    static void part2()
    {
        string path = @"D:\visual_studio_code_knowe_traing\Advent_Of_Code_2022\Day1\data.txt";
        string[] data = File.ReadLines(path).ToArray();

        List<int> resultList = new List<int>();

        int sum = 0;

        foreach (string line in data)
        {
            if (string.IsNullOrEmpty(line))
            {
                resultList.Add(sum);
                sum = 0;
            }
            else
                sum += int.Parse(line);
        }

        int[] sortList = resultList.OrderByDescending(x => x).ToArray();

        int result = sortList[0] + sortList[1] + sortList[2];
        Console.WriteLine(result);

    }


}