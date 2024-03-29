﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int PrintSumm (int start, int end, int sum)
{
    // Базовый случай
    if (start == end) return start + end;
    // Рекурсивный случай
    return (PrintSumm (sum  + 1, end));
}

Console.WriteLine(PrintSumm(1, N));

