using System;

int[] numbers = { 2, 4, 6 };

Console.WriteLine(Greeting.GetMessage());
Console.WriteLine($"Sum: {StatisticsHelper.CalculateSum(numbers)}");
Console.WriteLine($"Avg: {StatisticsHelper.CalculateAverage(numbers)}");
Console.WriteLine($"Array length: {numbers.Length}");
