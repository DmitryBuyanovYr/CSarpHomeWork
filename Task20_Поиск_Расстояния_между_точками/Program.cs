/*
Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
Console.Clear();
Console.Write("Введи координаты A(X): ");
int coorAx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи координаты A(Y): ");
int coorAy = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи Координаты B(X): ");
int coorBx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи Координаты B(Y): ");
int coorBy = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Координаты А: [{coorAx}]:[{coorAy}]");
System.Console.WriteLine($"Координаты B: [{coorBx}]:[{coorBy}]");

//Math.Sqrt - поиск порня числа
//Math.Pow - возведение в квадрат

double resalt = Math.Sqrt(Math.Pow((coorBx - coorAx), 2) + Math.Pow((coorBy - coorAy), 2)); //(coorBx * coorBx - (coorBx * coorAx) * 2 + coorAx * coorAx) + (coorBy * coorBy - (coorBy * coorAy) * 2 + coorAy * coorAy);
System.Console.WriteLine("расстояние между точками; " + Math.Round(resalt, 2)); //Math.Round(resalt, 2) - ограничение чисел после запятой

//double square2 = Math.Pow((coorBy - coorAy), 2);
//double resalt = Math.Sqrt(square1 /*+ square2*/);
//System.Console.WriteLine(resalt);
