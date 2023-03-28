using System;
using System.IO;
using System.Linq;

internal class ProgramDay2
{
    

    private static void Main(string[] args)
    {
        part1();
        part2();


    }

    static void part1()
    {
        var data =
        (from line in File.ReadAllLines(@"D:\visual_studio_code_knowe_traing\Advent_Of_Code_2022\Day2\data.txt")
         where !string.IsNullOrWhiteSpace(line)
         select line).ToArray();

        int totalScore = 0;
        

        int pRock = 1;
        int pPaper = 2;
        int pScissor = 3;

        int win = 6;
        int draw = 3;
        int lost = 0;

        char y_rock = 'X';
        char y_paper = 'Y';
        char y_scissor = 'Z';

        char o_rock = 'A';
        char o_paper = 'B';
        char o_scissor = 'C';

        for (int i = 0; i < data.Length; i++)
        {
            string[] columns = data[i].Split(' ');

            
            char op = columns[0][0];
            char me = columns[1][0];

            //win scenario
            if(op == o_rock && me == y_paper)
            {
                totalScore += win + pPaper;
            }
            if (op == o_paper && me == y_scissor)
            {
                totalScore += win + pScissor;
            }
            if (op == o_scissor && me == y_rock)
            {
                totalScore += win + pRock;
            }

            //draw scenario

            if (op == o_rock && me == y_rock)
            {
                totalScore += draw + pRock;
            }
            if (op == o_paper && me == y_paper)
            {
                totalScore += draw + pPaper;
            }
            if (op == o_scissor && me == y_scissor)
            {
                totalScore += draw + pScissor;
            }

            //lost scenario

            if (op == o_rock && me == y_scissor)
            {
                totalScore += lost + pScissor;
            }
            if (op == o_paper && me == y_rock)
            {
                totalScore += lost + pRock;
            }
            if (op == o_scissor && me == y_paper)
            {
                totalScore += lost + pPaper;
            }

        }

        Console.WriteLine("Total Score: " + totalScore);
    }


    static void part2()
    {
        var data =
        (from line in File.ReadAllLines(@"D:\visual_studio_code_knowe_traing\Advent_Of_Code_2022\Day2\data.txt")
         where !string.IsNullOrWhiteSpace(line)
         select line).ToArray();

        int totalScore = 0;


        int pRock = 1;
        int pPaper = 2;
        int pScissor = 3;

        int win = 6;
        int draw = 3;
        int lost = 0;

        char y_lose = 'X';
        char y_draw = 'Y';
        char y_win = 'Z';

        char o_rock = 'A';
        char o_paper = 'B';
        char o_scissor = 'C';

        for (int i = 0; i < data.Length; i++)
        {
            string[] columns = data[i].Split(' ');


            char op = columns[0][0];
            char me = columns[1][0];

            //win scenario
            if (op == o_rock && me == y_win)
            {
                totalScore += win + pPaper;
            }
            if (op == o_paper && me == y_win)
            {
                totalScore += win + pScissor;
            }
            if (op == o_scissor && me == y_win)
            {
                totalScore += win + pRock;
            }

            //draw scenario

            if (op == o_rock && me == y_draw)
            {
                totalScore += draw + pRock;
            }
            if (op == o_paper && me == y_draw)
            {
                totalScore += draw + pPaper;
            }
            if (op == o_scissor && me == y_draw)
            {
                totalScore += draw + pScissor;
            }

            //lost scenario

            if (op == o_rock && me == y_lose)
            {
                totalScore += lost + pScissor;
            }
            if (op == o_paper && me == y_lose)
            {
                totalScore += lost + pRock;
            }
            if (op == o_scissor && me == y_lose)
            {
                totalScore += lost + pPaper;
            }

        }

        Console.WriteLine("Total Score: " + totalScore);
    }










}


    

