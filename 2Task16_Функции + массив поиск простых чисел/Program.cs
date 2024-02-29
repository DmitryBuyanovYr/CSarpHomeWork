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
    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(50);
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("] ");

}

bool prost(int num)
{
    if (num == 0 || num == 1)
    {
        return false;
    }
    else
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}

int Count(int[] mas)
{
    int count = 0;
    foreach (var item in mas)
    {
        if (prost(item))
        {
            Console.Write($"{item} ");
            count++;
        }
    }
    Console.WriteLine();
    return count;
}

System.Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreationArray(size);
PrintArray(array);
System.Console.WriteLine();
Console.WriteLine(Count(array));



/*
int[] Random_mas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 10);
    }
    return mas;
}

void Print_mas(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

bool prost(int num)
{
    if (num == 0 || num == 1)
    {
        return false;
    }
    else
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}



int Count(int[] mas)
{
    int count = 0;
    foreach (var item in mas)
    {
        if (prost(item))
        {
            Console.Write($"{item} ");
            count++;
        }
    }
    Console.WriteLine();
    return count;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = Random_mas(new int[n]);
Print_mas(mas);

Console.WriteLine(Count(mas));
*/