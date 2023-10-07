/*
 Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/
System.Console.WriteLine("Введи число: ");
int Nambr = Convert.ToInt32(Console.ReadLine());
/*string day = "Ожидание";*/ //Вариант одногрупника
if (Nambr == 1) /*day = "Monday";
Console.Write(day);*/
{
    Console.Write("Monday");
}
if (Nambr == 2)
{
    Console.Write("Tuesday");
}
if (Nambr == 3)
{
    Console.Write("Wednesday");
}
if (Nambr == 4)
{
    Console.Write("Thursday");
}
if (Nambr == 5)
{
    Console.Write("Friday");
}
if (Nambr == 6)
{
    Console.Write("Saturday");
}
if (Nambr == 7)
{
    Console.Write("Sunday");
}
if (Nambr > 7 || Nambr < 1)
{
    Console.Write("Error");
}
/*int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;*/