/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
Console.Clear();
System.Console.Write("Введи число: ");
int userNambr = Convert.ToInt32(Console.ReadLine());
if (userNambr < 0)
{
    userNambr = userNambr * -1;
}
for (int i = 1; i < userNambr + 1; i++)
{
    System.Console.Write(i * i);
    if (i < userNambr)
    {
        System.Console.Write(", ");
    }
}