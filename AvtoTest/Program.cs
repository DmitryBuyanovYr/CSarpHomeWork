int[] array = new int[10];
void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] array2)
{
    System.Console.Write("[");
    for (int i = 0; i < array2.Length; i++)
    {
        System.Console.Write(array2[i]);
        if (i < array2.Length - 1)
        {
            System.Console.Write("; ");
        }
    }
    System.Console.Write("]");
}
int SumArray(int[] array3)
{
    int sum = 0;
    for (int i = 0; i < array3.Length; i++)
    {
        sum = sum + array3[i];
    }
    return sum;
}
int ProductArray(int[] array4)
{
    int prod = 1;
    for (int i = 0; i < array4.Length; i++)
    {
        prod = prod * array4[i];
    }
    return prod;
}


FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int sum = SumArray(array);
System.Console.WriteLine(sum);
int product = ProductArray(array);
System.Console.WriteLine(product);












