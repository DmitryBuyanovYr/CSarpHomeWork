﻿/*
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/
System.Console.Write("Введи число: ");
int Nambr = Convert.ToInt32(Console.ReadLine());
int i;
if (Nambr < 0)
{
    Nambr = Nambr * -1;
}
for (i = -Nambr; i < Nambr + 1; i++)
{
    Console.Write(i/*", "*/);
    if (i<Nambr)
    {
        Console.Write (", ");
    }
}
