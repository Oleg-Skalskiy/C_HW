/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


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
WriteLine("Отсортированный массив");
SortArray(array);
PrintArray(array);
WriteLine();

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


void  SortArray (int [,] array)
{
    int tmp =0;
    for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++)
        {
            for ( int h = 0; h< array.GetLength(1)-1; h++)
            if (array [i,h]< array [i,h+1])
            {
                tmp = array [i,h];
                array [i,h]=array [i,h+1];
                array [i,h+1] = tmp;
            }
        }
    }
}
