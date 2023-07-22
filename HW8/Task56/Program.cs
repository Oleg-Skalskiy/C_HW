/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(ReadLine());

int[,] array = new int[rows, columns];
WriteLine();
WriteLine("Наш массив");
GetArray(array);
PrintArray(array);
WriteLine();
MinSumNumber(array);
WriteLine();

int[,] GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write(inArray[i, j] + " ");
        }
        WriteLine();
    }
}

void MinSumNumber(int[,] array)
{
    int minLine = 0;
    int minLineSum = 0;
    int sumLine = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minLine += array[0, i];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumLine += array[i, j];
        if (sumLine < minLine)
        {
            minLine = sumLine;
            minLineSum = i;
        }
      
    }
    Write($"{minLineSum + 1} строка c наименьшей суммой ");
}