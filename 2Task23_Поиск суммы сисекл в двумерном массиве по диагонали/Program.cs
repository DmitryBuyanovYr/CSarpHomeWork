/*Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.*/

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


int SummIndex(int[,] array)
{
    int count =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                count = count + array[i,j];
            }
        }
    }
    return count;
}

System.Console.Write("Введи число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] arr = CreationDoubleArray(rows, columns);
PrintArray(arr);
System.Console.WriteLine();
int sum=0;
System.Console.WriteLine(sum = SummIndex(arr));

/*int[,] InputMatrixArrayFromKeyboard(int n, int m)
{
int[,] arr = new int[n, m];
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
Console.WriteLine($"Введите {j} элемент для строки {i}: ");
arr[i, j] = Convert.ToInt32(Console.ReadLine());
}
}
return arr;
}

void PrintArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
Console.Write($"{arr[i, j]}\t");
}
Console.WriteLine();
}
}

int SummarizeElementsMatrixArray(int[,] arr)
{
int s = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
if (i == j)
{
s = s + arr[i, j];
}
}
}
return s;
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = InputMatrixArrayFromKeyboard(n, m);
PrintArray(array);
int s = SummarizeElementsMatrixArray(array);
Console.WriteLine($"Сумма элементов находящихся на главной диагонали равна {s}");*/




