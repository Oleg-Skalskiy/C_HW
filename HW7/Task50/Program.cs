/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

if (rows < array.GetLength(0) && colums < array.GetLength(1))
    WriteLine(array[rows, colums]);
else
    WriteLine($"{rows}{colums} -> такого числа в массиве нет");
