/*
Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

System.Console.WriteLine("Введи координаты b1");
int b1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи координаты b2");
int b2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи координаты k1");
int k1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи координаты k2");
int k2 = Convert.ToInt32(Console.ReadLine());

void Formul(double b1, double b2, double k1, double k2)
{
    double resaltX = (b2 - b1) / (k1 - k2);
    double resaltY = k1 * (b2 - b1) / (k1 - k2) + b1;
    System.Console.Write($"[{resaltX}; {resaltY}]");
}
Formul(b1, b2, k1, k2);