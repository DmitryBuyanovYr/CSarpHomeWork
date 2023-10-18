/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();
System.Console.Write("Введи число: ");
int namber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи степень: ");
int degree = Convert.ToInt32(Console.ReadLine());


double DegreeNamber(int arg1, int arg2)
{
    double resalt = Math.Pow(arg1, arg2);
    return resalt;
}


double resalt = DegreeNamber(namber, degree);
System.Console.WriteLine($"Число {namber} в степени {degree} = {resalt}");