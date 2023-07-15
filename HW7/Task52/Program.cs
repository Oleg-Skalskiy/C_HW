/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

using System;
using static System.Console;

Clear();

Write("Введите индекс строки массива: ");
int rows = Convert.ToInt32(ReadLine());

Write("Введите индекс столбца массива: ");
int colums = Convert.ToInt32(ReadLine());

int[,] array = new int[rows, colums];

GetArray(array);
PrintArray(array);

double[] avgarray = new double[array.GetLength(1)];

for (int i = 0; i < array.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        result += array[j, i];
    }
    avgarray[i] = result / array.GetLength(0);
}

PrintArrayMas(avgarray);

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
    WriteLine();
}

void PrintArrayMas(double[] Sumarray)
{
    for (int i = 0; i < Sumarray.Length; i++)
    {
        Write(Sumarray[i] + " | ");
    }
    WriteLine();
}
