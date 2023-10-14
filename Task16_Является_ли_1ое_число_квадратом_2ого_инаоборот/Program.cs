/*
Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
Console.Clear();
System.Console.WriteLine("Введи первое число: ");
int firstNambr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int secondNammbr = Convert.ToInt32(Console.ReadLine());
if (firstNambr==secondNammbr*secondNammbr || secondNammbr==firstNambr*firstNambr)
{
    System.Console.WriteLine("Числа кратные");
}
else
{
    System.Console.WriteLine("числа НЕ кратные");
}