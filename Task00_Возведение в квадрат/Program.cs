/*
напишите программу, которая на вход принимает число  и выдает его квадрат
*/

System.Console.WriteLine("введи число: ");
int UserNambr = Convert.ToInt32(Console.ReadLine());
int square = UserNambr * UserNambr;
Console.WriteLine("ответ: " + square);