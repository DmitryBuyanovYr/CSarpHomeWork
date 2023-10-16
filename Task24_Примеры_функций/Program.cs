/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
System.Console.Write("Введи число: ");
int userNamber = Convert.ToInt32(Console.ReadLine());

int Numbers1(int namb)
{
    int summ = 0;
    for (int i = 0; i <= namb; i++)
    {
        summ = summ + i;

    }
    return summ;
}

int resalt = Numbers1(userNamber);
System.Console.WriteLine($"сумма чисел от 1 до {userNamber} = {resalt}");