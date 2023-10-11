/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
System.Console.WriteLine("Введи число: ");
int dayNambr = Convert.ToInt32(Console.ReadLine());
if (dayNambr > 0 && dayNambr <= 5)
{
    Console.WriteLine("Рабочий день ");
}
if (dayNambr == 6 || dayNambr == 7)
{
    Console.WriteLine("Выходной ");
}
/*else*/ if (dayNambr < 1 || dayNambr > 7)
{
    Console.WriteLine("Такого дня нет");
}
