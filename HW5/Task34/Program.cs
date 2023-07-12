/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */

Console.Clear();
int[] arrey = GiveArray();

int[] GiveArray()
{
    int length = new Random().Next(2, 40);
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
    return array;
}

int SumPl(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            number++;
    }
    return number;
}

Console.WriteLine($"[{String.Join(", ", arrey)}] -> " + SumPl(arrey));