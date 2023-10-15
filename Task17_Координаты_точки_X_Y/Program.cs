/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
и выдаёт номер четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4 
x=2; y=4-> 1
x=-34; y=-30 -> 3
*/
Console.Clear();
System.Console.WriteLine("Введи координаты X: ");
int coorXX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи Координаты Y: ");
int coorYY = Convert.ToInt32(Console.ReadLine());
if (coorXX>0 && coorYY>0)
{
    System.Console.WriteLine("Точка лежит в квадрате 1");
}
if (coorXX<0 && coorYY>0)
{
    System.Console.WriteLine("Точка лежит в квадрате 2");
}
if (coorXX<0&& coorYY<0)
{
    System.Console.WriteLine("Точка лежит в квадрате 3");
}
if (coorXX>0 && coorYY<0)
{
    System.Console.WriteLine("Точка лежит в квадрате 4");
}
if (coorXX==0 || coorYY==0)
{
    System.Console.WriteLine("Точка лежит в центре или на одной из оси"); // Лень расписывать все возможные случаи по этому объеденил
}
