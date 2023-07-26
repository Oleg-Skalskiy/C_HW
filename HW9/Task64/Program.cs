/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using System;
using static System.Console;

Clear();

Write("Введите число N: ");
int n = Convert.ToInt32(ReadLine());

WriteLine($"N = {n} -> {PrintNumber(n, 2)}");
string PrintNumber(int end, int start)
{
    if (start == end) return n.ToString();
    return (n + ", " + PrintNumber(n--, start));
}
