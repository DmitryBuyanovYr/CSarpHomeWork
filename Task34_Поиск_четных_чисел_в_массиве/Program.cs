/*
Напишите программу, которая подсчитывает количество четных 
элементов в массиве целых положительных трехзначных 
чисел и выводит результат на экран.
*/
Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

void EvenNumbers(int[] arrey)
{
    int result = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if ((arrey[i] % 2) == 0)
        result ++;
    }
    System.Console.WriteLine($"коллиество четных чисел в массиве = {result}");
}

System.Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] userArrey = GetRnd(size);
PrintArray(userArrey);
System.Console.WriteLine();
EvenNumbers(userArrey);