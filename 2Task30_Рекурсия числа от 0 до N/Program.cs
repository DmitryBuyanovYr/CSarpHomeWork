/*Напишите программу которая выводит все натуральные числа от 1 до N с помощью рекурсии*/


int EnumNumintr(int num)
{
    if (num == 1) return 1;

    System.Console.Write($"{EnumNumintr(num - 1)} ");

    return num;
} 



System.Console.Write("Веведи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write(EnumNumintr(userNumber));

////////////////////////////////// РЕШЕНИЕ ГРУППЫ:

void PrintNum (int num)
{
if (num < 1)
{
return;
}
Console.Write($"{num} ");
PrintNum(num - 1);
}
Console.WriteLine("Введите число равное M: ");
int m = Convert.ToInt32(Console.ReadLine());
//PrintNum(n);

string PrintNum(int n, int m)
{
if (n == m)
{
return Convert.ToString(n);
}
return n + " " + PrintNum(n + 1, m);
}
Console.WriteLine(PrintNum(1, m))*/