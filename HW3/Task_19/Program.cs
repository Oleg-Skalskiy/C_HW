/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num, count, sum = 0, b = sum;
num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    for (b = num; num != 0; num = num / 10)
    {
        count = num % 10;
        sum = sum * 10 + count;
    }

    if (b == sum)
        Console.Write($"{b} - является палиндромом.");
    else
        Console.Write($"{b} - не является палиндромом.");
}
else
    Console.Write($"{num} - не является пятизначным числом");
