/*
Напишите программу, которая находит сумму 
элементов с нечетными индексами в одномерном 
массиве целых чисел и выводит результат на экран.
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

void SummNotEven(int[] arrey)
{
    int result = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if ((i % 2) != 0)
        result = result + arrey[i];
    }
    System.Console.WriteLine($"Сумма чисел с нечетным инексом = {result}");
}

System.Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] userArrey = GetRnd(size);
PrintArray(userArrey);
System.Console.WriteLine();
SummNotEven(userArrey);