/*Задайте одномерный массив, заполненный случайными числами. 
Определите количество простых чисел в этом массиве.
Примеры
[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13] => 3*/

int[] CreationArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

void PrintArray(int[] array)
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

int FindingPrimeNumber(int[] array)
{
    int count = 0;
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] % array[i] == 0 && array[i] % 2 != 0)
        {
            count ++;
        }
    }
    return count;
}

System.Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
CreationArray(size);
System.Console.WriteLine();
PrintArray(array);
//System.Console.WriteLine(FindingPrimeNumber(array));
