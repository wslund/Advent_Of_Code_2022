using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2022.Day3
{
    internal class ProgramDay3
    {
        private static void Main(string[] args)
        {
            part1();
            part2();
            


        }

        static void part1()
        {
            var data = File.ReadAllText(@"D:\visual_studio_code_knowe_traing\Advent_Of_Code_2022\Day3\data.txt")
                .Split('\n', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            

            var result = data
                    .Select(rucksack =>
                        new ValueTuple<string, string>(
                            rucksack.Substring(0, rucksack.Length / 2),
                            rucksack.Substring(rucksack.Length / 2, rucksack.Length / 2)))
                    .Select(compartments => compartments.Item1.Intersect(compartments.Item2))
                    .Aggregate(0, (sum, commonItem) => sum + GetPriority(commonItem.First()));

            Console.WriteLine(result);
        }

        static void part2()
        {
            var data = File.ReadAllText(@"D:\visual_studio_code_knowe_traing\Advent_Of_Code_2022\Day3\data.txt")
                .Split('\n', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = data
                .Chunk(3)
                .Select(group => group[2].Intersect(group[1].Intersect(group[0])))
                .Aggregate(0, (sum, commonItem) => sum + GetPriority(commonItem.First()));


            Console.WriteLine(result);

        }

        static int GetPriority(char item)
        {
            return item - 'a' >= 0 ? item - 'a' + 1 : item - 'A' + 27;
        }

    }
}
