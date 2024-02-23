/*
Напишите программу, которая принимает на вход 
число и проверяет, кратно ли оно одновременно 7 и 23. 
50 -> нет 322 -> да
*/
Console.Clear();
System.Console.WriteLine("Введи число: ");
int numUser = Convert.ToInt32(Console.ReadLine());
int num1 = 7;
int num2 = 23;
if (numUser % num1 == 0 && numUser % num2 == 0)
{
    System.Console.WriteLine($"число {numUser} Кратно {num1} и {num2}");
}
else System.Console.WriteLine($"число {numUser} не Кратно {num1} и {num2}");