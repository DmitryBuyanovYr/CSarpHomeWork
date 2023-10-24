﻿/*
37. Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21


int[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void Output(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] MultArray(int[] array)
{
    int[] result = new int[array.Length - array.Length / 2];
    int temp = 0;
    for (int i = 0; i < array.Length - array.Length / 2; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
            continue;
        }

        temp = array[i] * array[array.Length - 1 - i];
        result[i] = temp;
    }
    return result;
}

int[] array = CreateArray(7, 1, 5);
Output(array);
System.Console.WriteLine();
int[] array2 = MultArray(array);
Output(array2);
*/




/*
37. Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и 
предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
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

int[] MultArray(int[] array)
{
    int[] result = new int[array.Length - array.Length / 2];
    int temp = 0;
    for (int i = 0; i < array.Length - array.Length / 2; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
            continue;
        }

        temp = array[i] * array[array.Length - 1 - i];
        result[i] = temp;
    }
    return result;
}

Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRnd(size);
PrintArray(userArray);
System.Console.WriteLine();
int[] userArray2 = MultArray(userArray);
PrintArray(userArray2);