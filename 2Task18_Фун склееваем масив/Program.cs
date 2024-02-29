/*Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из массива. 
Старший разряд числа находится на 0-м индексе, младший – на последнем.
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231*/


int[] CreationArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
    return array;

}

void PrintArray(int[] array)
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


/*bool Examination(int size)
{
    if (size>0 && size<8) return true
}*/
 int ConnectsNumbers(int[]mas)
 {
    Array.Reverse(mas);
    int factor = 1;
    int resalt = 0;

    for (int i = 0; i < mas.Length; i++)
    {
        resalt = resalt + mas[i] * factor;
        factor = factor * 10;
    }
    Array.Reverse(mas);
    return resalt;
 }

System.Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreationArray(size);
if (size >= 0 && size <=8)
{
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(ConnectsNumbers(array));
}
else System.Console.WriteLine("Ошибка");
/*Array.Reverse(array);
Console.WriteLine(string.Join(" ", array));*/
/*                                                 

                                                         решение группы

double ArrayToNumber (int [] a)
{
double s = 0;
for (int i = 0; i < a.Length; i++)
{
double p = Math.Pow(10,a.Length-i-1);
s = s + a[i]*p;
}
return s;
}

Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = ArrayInput(n);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArrayToNumber(array));
*/