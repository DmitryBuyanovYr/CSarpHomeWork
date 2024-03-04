int[] array = { 1, 2, 10, 8, 0, 3, 6, 7, 11, 12 };
int srednee = 0;
for (int i = 0; i < array.Length; i++)
{
    srednee = srednee + array[i];
}
srednee = srednee / array.Length;
System.Console.WriteLine(srednee);



/*int[,] CreationDoubleArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

int rows = 1;
int columns = 3;

int[,] arr = CreationDoubleArray(rows, columns);
PrintArray(arr);

int [,] array = CreationDoubleArray(rows, columns);

int[] array2 = new int[columns];
int index = 0;
int k = 0;
for (int j = 0; j < array.GetLength(1); j++) // смена строчки
{
    for (int i = 0; i < array.GetLength(0); i++) // смена столбца
    {
        index = index + array[i, j];
        System.Console.Write(index + " ");
    }

    index = index / array2.Length;
    array2[k] = index;
    k++;
}
System.Console.WriteLine();
System.Console.WriteLine(index);
*/

