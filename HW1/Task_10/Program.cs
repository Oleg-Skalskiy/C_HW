/*
Задача 10: Напишите программу, которая на вход принимает трехзначное число, а на выходе показывает последнюю цифру этого числа
*/
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    int last = (number % 10);
    Console.Write($"{last} - это последняя цифра в числе {number}");
}
else
Console.Write("Это не трёхзначное число");
