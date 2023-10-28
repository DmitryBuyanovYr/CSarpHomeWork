/*
Напишите программу для работы с массивом вещественных чисел.
Реализуйте класс  который содержит следующие статические методы:

1. Метод принимает на вход массив вещественных чисел 
array и возвращает максимальное число из массива.

2. Метод принимает на вход массив вещественных 
чисел array и возвращает минимальное число из массива.

3.Метод принимает на вход массив вещественных чисел 
array и возвращает разницу между максимальным и минимальным числами в массиве.

4. Метод для вывода массива на экран. Он принимает на 
вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.
*/

Console.Clear();

double[] GetRnd(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-90, 100) + new Random().NextDouble();//new Random().NextDouble()(*10 создание массива от 0 до 10); -> создание чисел после ,!!!
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(50);
        System.Console.Write(Math.Round(arr[i], 2));
        if (i < arr.Length - 1)
            System.Console.Write("; ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("] ");
    Console.ResetColor();
}

double Max(double[] arrey)
{
    double max = arrey[0];
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] > max) max = arrey[i];
    }
    return max;
}

double Min(double[] arrey)
{
    double min = arrey[0];
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] < min) min = arrey[i];
    }
    return min;
}

double Difference(double[] arrey)
{
    double max = Max(arrey);
    double min = Min(arrey);
    double diff = max - min;
    return diff;
}

System.Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] userArray = GetRnd(size);
PrintArray(userArray);
System.Console.WriteLine();
System.Console.WriteLine($"Мax число = {Math.Round(Max(userArray), 2)}");
System.Console.WriteLine($"Мин число = {Math.Round(Min(userArray), 2)}");
System.Console.WriteLine($"Разница между МАХ и MIN = {Math.Round(Difference(userArray), 2)}");