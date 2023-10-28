/*
Напишите программу которая принимает 3 числа и проверяет 
может ли существовать треугольник с такими сторонами
*/
Console.Clear();

System.Console.Write("Введи первое число: ");
double first = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи второе число: ");
double second = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи третье число: ");
double last = Convert.ToInt32(Console.ReadLine());

void Trio(double arg1, double arg2, double arg3)
{
    if(arg1 + arg2 <= arg3)
    {
        System.Console.WriteLine("Такого треугольника не существует");
    }
    else if (arg1 + arg3 <= arg2)
    {
        System.Console.WriteLine("Такого треугольника не существует");
    }
    else if (arg3 + arg2 > arg1)
    {
        System.Console.WriteLine("ура треугольник получился");
    }
    else System.Console.WriteLine("Такого треугольника не существует");
}

Trio(first, second, last);