/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
 */

Console.Clear();
double[] arrey = GiveArray();

double[] GiveArray()
{
    int length = new Random().Next(2, 10);
    double[] array = new double[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 10000) / 100.0;
    }
    return array;
}

double MinArray(double[] array)
{
    double min = arrey[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

double MaxArray(double[] array)
{
    double max = arrey[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}
double itog = MaxArray(arrey) - MinArray(arrey);
System.Console.WriteLine($"[{String.Join(", ", arrey)}] => {MaxArray(arrey)} - {MinArray(arrey)} = {itog}");
