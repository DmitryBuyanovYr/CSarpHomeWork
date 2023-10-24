/*
33. Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
/*
Console.Clear();
Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введи число: ");
//int number = Convert.ToInt32(Console.ReadLine());



int[] NewArrey(int size)
{
    int[] arrey = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrey[i] = new Random().Next(-9, 10);
    }
    return arrey;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

bool SearchNamber(int[] array1, int number)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] == number) return true;
    }
    return false;
}


int[] userArray = NewArrey(size);
PrintArray(userArray);
System.Console.WriteLine();
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SearchNamber(userArray, number));
*/

Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
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
        Thread.Sleep(95);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("] ");
    Console.ResetColor();
}

bool Numb(int[] arr, int srav)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == srav) return true;
    }
    return false;
}

Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRnd(size);
PrintArray(userArray);
System.Console.WriteLine(Numb(userArray,number));
