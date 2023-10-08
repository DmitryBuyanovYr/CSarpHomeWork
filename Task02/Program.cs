/*
Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.


a = 5; b = 7 -> Первое число 5 меньше чем второе число 7

a = 2; b = 2 -> Введенные числа равны 2

a = -3; b = -9 -> Первое число -3 больше чем второе число -9
*/
System.Console.Write("Введи число: ");
int firstNambr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNammbr = Convert.ToInt32(Console.ReadLine());
if (firstNambr > secondNammbr)
{
    Console.Write("самое большое число: " + firstNambr);
}
if (firstNambr < secondNammbr)
{
    Console.Write("самое большое число: " + secondNammbr);
}
if (firstNambr == secondNammbr)
{
    Console.Write("числа равны:");
}