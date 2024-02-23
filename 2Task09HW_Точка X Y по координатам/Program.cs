/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
в которой находится эта точка.
*/

Console.Clear();
System.Console.Write("Введи координаты Х: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0) System.Console.WriteLine("Неверные координаты");

if (x > 0 && y > 0) System.Console.WriteLine("Точка находиться в 1 четверти");
else if (x < 0 && y > 0) System.Console.WriteLine("Точка находиться в 2 четверти");
else if (x < 0 && y < 0) System.Console.WriteLine("Точка находиться в 3 четверти");
else if (x > 0 && y < 0) System.Console.WriteLine("Точка находиться в 4 четверти");

