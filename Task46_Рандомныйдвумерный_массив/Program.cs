/*
46. Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
*/
int[,] Get2dArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1) System.Console.Write(", ");
        }
        System.Console.Write("]");
        System.Console.WriteLine();
    }
}
int[,] user2dArray = Get2dArray(2, 10);
Print2dArray(user2dArray);