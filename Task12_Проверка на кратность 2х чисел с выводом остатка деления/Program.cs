/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/
System.Console.WriteLine("Введи первое число: ");
int firstNambr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int secondNammbr = Convert.ToInt32(Console.ReadLine());
//double remains = 0;
if (secondNammbr % firstNambr == 0)
{
    System.Console.WriteLine($"число {secondNammbr} кратное числу {firstNambr}");
}
else
{
    System.Console.WriteLine("Остаток: " + firstNambr % secondNammbr);
    //remains = secondNammbr % firstNambr;
    // System.Console.WriteLine((remains));
}