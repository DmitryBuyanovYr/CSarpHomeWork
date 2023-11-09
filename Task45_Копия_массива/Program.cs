/*
написать програму которая делает копию одномерного 
массива с помощью поэлементрого копирования
*/

System.Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

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

void Copy(int[] arrey1, int size)
{
    int[] arrey2 = new int[size];
    for (int i = 0; i < arrey1.Length; i++)
    {
        arrey2[i] = arrey1[i];
    }
    PrintArray(arrey2);
}

int[] userArrey = GetRnd(size);
PrintArray(userArrey);
System.Console.WriteLine();
Copy(userArrey, size);