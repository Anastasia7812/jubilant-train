﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("введите целое число 1");
int a = Convert.ToInt32(Console.ReadLine());
int  remDiv=a%2;
if(remDiv == 0)
{
    Console.WriteLine($" {a} - Четное число ");
}
else
{
    Console.WriteLine($" Нечетное число ");
}