﻿/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

Console.Clear();
Console.WriteLine("Даны прямые заданные по формулам y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите через пробел b1, k1, b2 и k2: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = arr[1];
int b = arr[3];
int c = arr[0];
int d = arr[2];
double pointX;
double pointY;
if (a == b)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double)(d - c) / (a - b);
    pointY = (double)a * (d - c) / (a - b) + c;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.00}");
    Console.WriteLine($"Y: {pointY:0.00}");
}