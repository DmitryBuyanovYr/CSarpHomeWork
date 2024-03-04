/*Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, 
состоящий из средних арифметических значений по строкам двумерного массива.*/

int[,] CreationDoubleArray(int rows, int columns)
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

double[] HuetaArray(int[,] array, int rows)
{
    double[] array2 = new double[array.GetLength(0)];
    for (int j = 0; j < array.GetLength(0); j++) // смена строчки
    {
        double srednee = 0;
        for (int i = 0; i < array.GetLength(1); i++) // смена столбца
        {
            srednee = srednee + array[j, i];
        }
        array2[j] = srednee / array.GetLength(1);
        

    }

    return array2;
}
void PrintArray2(double[] array)
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


System.Console.Write("Введи число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreationDoubleArray(rows, columns);
PrintArray(arr);
double[] array2 = HuetaArray(arr, rows);
PrintArray2(array2);




