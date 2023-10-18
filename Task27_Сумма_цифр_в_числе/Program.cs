/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Clear();
System.Console.Write("Введи число: ");
int namber = Convert.ToInt32(Console.ReadLine());

if (namber < 0)
{
    namber *= -1;
}

double SumNamber(int arg1)
{
    int resalt1 = 0;
    for (int i = arg1; i > 0; i = i / 10)
    {
        resalt1 = resalt1 + i % 10;
    }
    return resalt1;
}

double resalt = SumNamber(namber);
System.Console.WriteLine($"Сумма цифр числа {namber} = {resalt}");