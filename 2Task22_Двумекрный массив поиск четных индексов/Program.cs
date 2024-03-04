/*Задайте двумерный массив. Найдите элементы, у которых оба 
индекса чётные, и замените эти элементы на их квадраты.*/

int[,] CreationDoubleArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
    return array;

}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }


}


int[,] SearchEvenIndex(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
}


System.Console.Write("Введи число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] arr = CreationDoubleArray(rows, columns);
PrintArray(arr);
System.Console.WriteLine();
arr = SearchEvenIndex(arr);
PrintArray(arr);


