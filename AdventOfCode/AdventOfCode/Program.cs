﻿using AdventOfCode.AdventClient;
using AdventOfCode.AdventInput;
using System;
using System.Diagnostics;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            SolveDay1();
            SolveDay2();
        }

        static void SolveDay1()
        {
            var adventClient = new AdventHttpClient();
            var adventInput = new AdventInputProvider(adventClient);
            var day1 = new Day1(adventInput);

            var frequency = day1.CalculateFrequency().Result;
            Console.WriteLine($"Day 1 frequency: {frequency}");

            var duplicateFrequency = day1.GetFirstFrequencyDuplication().Result;
            Console.WriteLine($"Day 1 frequency duplication: {duplicateFrequency}");
        }

        static void SolveDay2()
        {
            var adventClient = new AdventHttpClient();
            var adventInput = new AdventInputProvider(adventClient);
            var day2 = new Day2(adventInput);

            var checksum = day2.CalculateChecksum().Result;
            Console.WriteLine($"Day 2 checksum: {checksum}");

            var boxId = day2.GetStringOfCommonLettersFromMostSimilarBoxIds().Result;
            Console.WriteLine($"Day 2 BoxId : {boxId}");
        }
    }
}
