/*
 Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/
Console.Clear();
System.Console.WriteLine("Введите номер четвери: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter == 1)
{
    System.Console.WriteLine("Х=[0 ; +∞]:Y=[0 ; +∞]");
}
if (quarter==2)
{
    System.Console.WriteLine("Х=[0 ; -∞]:Y=[0 ; +∞]");
}
if (quarter==3)
{
    System.Console.WriteLine("Х=[0 ; -∞]:Y=[0 ; -∞]");
}
if (quarter==4)
{
    System.Console.WriteLine("Х=[0 ; +∞]:Y=[0 ; -∞]");
}
if (quarter>4 || quarter<1)
{
    System.Console.WriteLine("Такой четверти нет! ");
}