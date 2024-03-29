﻿var day1 = new Day1();
Console.WriteLine(day1.Part1Simple()); //1266
Console.WriteLine(day1.Part2Simple()); //1217
Console.WriteLine(day1.Part1()); //1266
Console.WriteLine(day1.Part2()); //1217

var day2 = new Day2();
Console.WriteLine(day2.Part1()); // 2150351
Console.WriteLine(day2.Part2()); // 1842742223

var day3 = new Day3();
Console.WriteLine(day3.Part1()); // 3429254
Console.WriteLine(day3.Part2()); // 5410338

var day4 = new Day4("Data/Day4/input.txt");
Console.WriteLine(day4.Part1().Value.Total); //72770
Console.WriteLine(day4.Part2().Value.Total); //13912

var day5 = new Day5();
Console.WriteLine(day5.Part1()); //5197
Console.WriteLine(day5.Part2()); //18605

var day6 = new Day6();
Console.WriteLine(day6.Part1(80)); // 372984
Console.WriteLine(day6.Part2(256)); //1681503251694

var day7 = new Day7();
Console.WriteLine(day7.Part1()); // 349769
Console.WriteLine(day7.Part2()); // 99540554

var day8 = new Day8();
Console.WriteLine(day8.Part1()); // 294
Console.WriteLine(day8.Part2()); // 973292

var day9 = new Day9();
Console.WriteLine(day9.Part1()); // 502
Console.WriteLine(day9.Part2()); // 1330560

var day10 = new Day10();
Console.WriteLine(day10.Part1()); // 339411
Console.WriteLine(day10.Part2()); // 264368900

var summary = BenchmarkRunner.Run<Day10>();
