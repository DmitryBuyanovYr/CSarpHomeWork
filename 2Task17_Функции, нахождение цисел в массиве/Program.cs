/*Задайте масив из N чисел вводимые пользователем найдите в 
массииве числа которые заканчиваються на 1 и деляься на 7*/

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

int SearchNumbers1(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0)
        {
            System.Console.WriteLine(array[i]);
            count++;
        }
    }
    return count;
}
System.Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mas = CreationArray(size);
PrintArray(mas);
System.Console.WriteLine();
System.Console.WriteLine(SearchNumbers1(mas));