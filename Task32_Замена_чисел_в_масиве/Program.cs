/*
32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
System.Console.Write("Введи число: ");
int nambr = Convert.ToInt32(Console.ReadLine());


int[] NewArrey(int size)
{
    int[] arrey = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrey[i] = new Random().Next(-9, 10);
    }
    return arrey;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int[] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

int[] userArray = NewArrey(nambr);
PrintArray(userArray);
int[] revUsArr = ReverseArray(userArray);

System.Console.WriteLine();

PrintArray(revUsArr);
