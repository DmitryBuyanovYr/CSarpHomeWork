/*Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)*/

int[] CreationArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 9);
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

int[] ReverseArrray(int[]array)
{
Array.Reverse(array);
return array;
}


System.Console.WriteLine("Введи размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreationArray(size);
PrintArray(arr);
arr = ReverseArrray(arr);
System.Console.WriteLine();
PrintArray(arr);


