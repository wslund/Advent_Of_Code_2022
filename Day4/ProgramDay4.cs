using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Advent_Of_Code_2022.Day4
{
    internal class ProgramDay4
    {
        private static void Main(string[] args)
        {
            part1();
            part2();

        }

        static void part1()
        {
            var regex = new Regex("(\\d+)-(\\d+),(\\d+)-(\\d+)");

			var data =
					(from line in File.ReadAllLines(@"D:\visual_studio_code_knowe_traing\Advent_Of_Code_2022\Day4\data.txt")
						where !string.IsNullOrWhiteSpace(line)
						let match = regex.Match(line)
						select (
						left: (
							low: long.Parse(match.Groups[1].Value),
							high: long.Parse(match.Groups[2].Value)
						),
						right: (
							low: long.Parse(match.Groups[3].Value),
							high: long.Parse(match.Groups[4].Value)
						)
						)
					).ToArray();

			var result = 0;

			foreach (var (left, right) in data)
			{
				if (left.low <= right.low && left.high >= right.high)
					result++;
				else if (right.low <= left.low && right.high >= left.high)
					result++;
			}

			Console.WriteLine(result);
		}

		static void part2()
        {
			var regex = new Regex("(\\d+)-(\\d+),(\\d+)-(\\d+)");

			var data =
					(from line in File.ReadAllLines(@"D:\visual_studio_code_knowe_traing\Advent_Of_Code_2022\Day4\data.txt")
					 where !string.IsNullOrWhiteSpace(line)
					 let match = regex.Match(line)
					 select (
					 left: (
						 low: long.Parse(match.Groups[1].Value),
						 high: long.Parse(match.Groups[2].Value)
					 ),
					 right: (
						 low: long.Parse(match.Groups[3].Value),
						 high: long.Parse(match.Groups[4].Value)
					 )
					 )
					).ToArray();

			var result = 0;

			foreach (var (left, right) in data)
			{
				if (left.low >= right.low && left.low <= right.high)
					result++;
				else if (left.high >= right.low && left.high <= right.high)
					result++;
				else if (right.low >= left.low && right.low <= left.high)
					result++;
				else if (right.high >= left.low && right.high <= left.high)
					result++;

			}

			Console.WriteLine(result);

		}

	}
}
