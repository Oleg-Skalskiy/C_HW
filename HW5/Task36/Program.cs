/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

Console.Clear();
int[] arrey = GiveArray();

int[] GiveArray()
{
    int length = new Random().Next(2, 10);
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int SumPl(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            number += array[i];
    }
    return number;
}

Console.WriteLine($"[{String.Join(", ", arrey)}] -> " + SumPl(arrey));