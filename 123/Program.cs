/*Задайте одномерный массив, заполненный случайными числами. 
Определите количество простых чисел в этом массиве.
Примеры
[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13] => 3*/

int[] CreationArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,51);
        
    }
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("; ");
        }
    }
    System.Console.Write("]");
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("; ");
        }
    }
    System.Console.Write("]");
}

int FindingPrimeNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % array[i] == 0 /*&& array[i] % 2 != 0*/)
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
//PrintArray(array);
System.Console.WriteLine(FindingPrimeNumber(array));
