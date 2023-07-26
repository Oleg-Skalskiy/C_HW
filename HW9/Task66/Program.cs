/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using System;
using static System.Console;

Clear();

Write("Введите число M: ");
int m = Convert.ToInt32(ReadLine());

Write("Введите число N: ");
int n = Convert.ToInt32(ReadLine());

void SumNum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов -> {sum}");
        return;
    }
    sum = sum + (m++);
    SumNum(m, n, sum);
}
SumNum(m, n, 0);
