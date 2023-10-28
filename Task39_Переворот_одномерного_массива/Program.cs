/*
Напишите_программу_которая_перевернет_одномерный_массив
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

void Reverse(int[] array)
{
    Array.Reverse(array);
    Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Thread.Sleep(50);
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write("]");
}

System.Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] userArrey = GetRnd(size);
PrintArray(userArrey);
System.Console.WriteLine();
Reverse(userArrey);