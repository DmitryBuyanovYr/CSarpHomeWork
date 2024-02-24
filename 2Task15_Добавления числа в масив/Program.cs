/*Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. 
Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м.
456 => [6 5 4]         781 => [1 8 7]           */


void PrintMas(int[] a)
{
foreach (var i in a)
{
Console.Write($"{i} ");
}
Console.WriteLine();
}

int n = new Random().Next(100, 1000);
Console.WriteLine(n);

int[] mas = new int[3];

for (int i = 0; i < mas.Length; i++)
{
mas[i] = n % 10;
n /= 10;
}
PrintMas(mas);


/*Console.Clear();
System.Console.Write("Введи техзначное число: ");
int numberUser = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 0;
int c = 0;

int[] array = new int[3];

System.Console.WriteLine();
if (numberUser > 99 && numberUser < 1000)
{
    a = numberUser / 100;
    b = numberUser / 10 % 10;
    c = numberUser % 10;
    array[2] = a;
    array[1] = b;
    array[0] = c;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
    {
        System.Console.Write("; ");
    }
    }
}
*/