/*Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
Замените отрицательные элементы на положительные, а положительные на отрицательные.
[1 -5 6]
=> [-1 5 -6]*/

int[] array = { 1, -2, 10, -8, 0, -3, 6, -7, 11, -12 };

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i]);
    if (i< array.Length-1)
    {
        System.Console.Write("; ");
    }
}

System.Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
    System.Console.Write(array[i]);
    if (i< array.Length-1)
    {
        System.Console.Write("; ");
    }
}