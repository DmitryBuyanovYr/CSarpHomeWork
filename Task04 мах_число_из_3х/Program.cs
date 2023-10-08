/*
Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
System.Console.Write("Введи первое число: ");
int firstNambr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int secondNambr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int thirdNambr = Convert.ToInt32(Console.ReadLine());
int max = firstNambr;
if (secondNambr > max)
{
    max = secondNambr;
}
if (thirdNambr > max)
{
    max = thirdNambr;
}
Console.Write("Max число: " + max);