/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

using System;
using static System.Console;
Clear();

Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"A(m,n) = {AckermannFunction(m, n)}");

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return (AckermannFunction(m - 1, AckermannFunction(m, n - 1)));
    }
}
