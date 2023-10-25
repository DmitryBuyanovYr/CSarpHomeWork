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

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(50);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("] ");
    Console.ResetColor();
}

int Max(int[] arrey)
{
    int max = arrey[0];
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i]>max) max = arrey[i];
    }
    return max;
}

int Min(int[] arrey)
{
    int min = arrey[0];
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i]<min) min = arrey[i];
    }
    return min;
}

int Difference(int[] arrey)
{
    int max = Max(arrey);
    int min = Min(arrey);
    int diff = max - min;
    return diff;
}

System.Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] userArrey = GetRnd(size);
PrintArray(userArrey);
System.Console.WriteLine();
System.Console.WriteLine($"Мax число = {Max(userArrey)}");
System.Console.WriteLine($"Мин число = {Min(userArrey)}");
System.Console.WriteLine($"Разница между МАХ и MIN = {Difference(userArrey)}");