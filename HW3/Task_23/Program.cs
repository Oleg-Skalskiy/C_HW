/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
Console.Write("Введите число N: ");

int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i}^3 {i * i * i}");
}
int ReadInt(string sum)
{
    Console.Write(sum);
    return Convert.ToInt32(Console.ReadLine());
}
