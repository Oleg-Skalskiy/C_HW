/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
 */

Console.Clear();
int Prompt(string msg)
{
    System.Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число: ");
int num3(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool check(int number)
{
    if (number < 100)
        return false;
    else return true;
}

if (check(number) != true)
    System.Console.WriteLine($"В числе {number} нет третьей цифры");
else
    System.Console.WriteLine($"Третья цифра {number} является число {num3(number)}");
