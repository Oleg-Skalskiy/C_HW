/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(ReadLine());

Write("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(ReadLine());
double[,] numbers = new double[rows, colums];

GetArray(numbers);
PrintArray(numbers);

void GetArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10000, 10000) / 100.0;
        }
    }
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
