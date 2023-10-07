/*
Написать программу определяющая является ли 1ое число квадратом 2ого
*/
System.Console.WriteLine("Введите первое число: ");
int firstNambr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNammbr = Convert.ToInt32(Console.ReadLine());
if (firstNambr == secondNammbr * secondNammbr /* || secondNammbr==firstNambr*firstNambr*/)// крутая тема но не совсем подходит к условиям данной задачи ;) 
{
    Console.Write("Число " + firstNambr);
    Console.Write(" является квадратом к числу " + secondNammbr);
}
else
{
    Console.Write($"Число {firstNambr} не является квадратом к числу {secondNammbr}");
}
