using System;

int[] numbers = { 2, 4, 6 };
int[] numbersNegative = { -8, -3, -5 };

Console.WriteLine(Greeting.GetMessage());
Console.WriteLine($"Sum: {StatisticsHelper.CalculateSum(numbers)}");
Console.WriteLine($"Avg: {StatisticsHelper.CalculateAverage(numbers)}");
Console.WriteLine($"Array length: {numbers.Length}");
Console.WriteLine($"Max: {StatisticsHelper.CalculateMax(numbers)}");
Console.WriteLine($"Max negative: {StatisticsHelper.CalculateMax(numbersNegative)}");
