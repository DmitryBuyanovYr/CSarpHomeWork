/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
[-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна -20
*/
System.Console.Write("Введи число: ");
int nambr = Convert.ToInt32(Console.ReadLine());


int[] NewArrey(int size)
{
    int[] arrey = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrey[i] = new Random().Next(-9, 9);
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


int SearchPositive(int[] array) // сумма
{
int positive = 0; // пооложительные
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positive = positive + array[i];
    }
}
System.Console.WriteLine($"сумма положительных чисел: {positive}");
return positive;
}


int SearchEgative(int[] array) // сумма
{
int egative = 0; // отрицальельные
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        egative = egative + array[i];
    }
}
System.Console.WriteLine($"сумма отрицательных чисел: {egative}");
return egative;

}


int[] userArray = NewArrey(nambr);
PrintArray(userArray);
System.Console.WriteLine("");
int negative = SearchPositive(userArray);
int egative = SearchEgative(userArray);

/*
void SumArray(int[] arr)
{
    int summPos = 0;
    int summNeg = 0;
    for (int i = 0; i < arr.Length; i++)
        {
        if(arr[i] > 0) summPos = summPos + arr[i];
        else summNeg = summNeg + arr[i];
        }
System.Console.WriteLine("Сумма положительных чисел в массиве равна:" + summPos);
System.Console.Write("Сумма отрицательных чисел в массиве равна:" + summNeg);
}
*/