﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//           является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("***************************************");
Console.WriteLine("Проверим четность или нечетность числа");
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a % 2) == 0) //проверим чему равен остаток от деления на 2
{
    Console.WriteLine("Вы ввели четное число");
    Console.WriteLine("***************************************");
}
else
{
    Console.WriteLine("Вы ввели нечетное число");
    Console.WriteLine("***************************************");
}