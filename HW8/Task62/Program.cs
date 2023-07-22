/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

using System;
using static System.Console;
Clear();

int i = 0;
int j = 0;
int n = 4;
int[,] spiralArray = new int[n, n];

GetSpiral(spiralArray);
PrintArray(spiralArray);

void GetSpiral(int[,] spiralArray)
{
for (int tmp = 1; tmp <= spiralArray.GetLength(0) * spiralArray.GetLength(1); tmp++)
{
    spiralArray[i, j] = tmp;
    if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
        j--;
    else
        i--;
}
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
