/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
Console.Clear();
System.Console.WriteLine("Введи число: ");
int namber = Convert.ToInt32(Console.ReadLine());
if (namber % 7 == 0 && namber % 23 == 0) // можно писать & или && работают оба варианта
{
    System.Console.WriteLine($"Число {namber} подходит");
}
else
{
    System.Console.WriteLine($"число {namber} не подходит");
}