/*Задайте массив. Напишите программу, которая определяет, присутствует 
ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да*/
Console.Clear();
System.Console.Write("Введи число: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];
int[] array2 = new int[sizeArray / 2];

System.Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 50);
    System.Console.Write(array[i]);
    if (i < array.Length - 1)
    {
        System.Console.Write("; ");
    }
}
System.Console.Write("]");
System.Console.WriteLine();
System.Console.Write("[");
for (int i = 0; i < array.Length / 2; i++)
{
    array2[i] = array[i] * array[array.Length - i - 1];
    System.Console.Write(array2[i]);
    if (i < array.Length / 2 - 1)
    {
        System.Console.Write("; ");
    }
}
System.Console.Write("]");