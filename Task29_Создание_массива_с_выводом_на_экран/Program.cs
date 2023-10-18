/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] GetRnd(int size)
{
    int[] array = { 10, 80, 62, 48, 72, 54, 11, 31 };
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}
int[] userArray = GetRnd(8);
PrintArray(userArray);