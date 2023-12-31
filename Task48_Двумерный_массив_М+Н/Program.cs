﻿/*
48. Задайте двумерный массив размера m на n, каждый 
элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3 
1 2 3 4
2 3 4 5
*/

int[,] Get2dArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = i + j;
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
int[,] user2dArray = Get2dArray(3, 4);
Print2dArray(user2dArray);