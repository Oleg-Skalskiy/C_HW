﻿/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
 */

Console.Clear();
int Prompt(string msg)
{
    System.Console.Write($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите день недели: ");
string ss = "Это не день недели";
string check(int number)
{
    if (number >= 6 && number < 8) ss = "Это выходной день";
    if (number >= 1 && number < 7) ss = "Это рабочий день";
    return ss;
}
System.Console.WriteLine(check(number));
