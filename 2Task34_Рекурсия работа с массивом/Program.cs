//Задайте произвольный массив. Выведете его элементы, начиная 
//с конца. Использовать рекурсию, не использовать циклы.

int[] CreationArray(int size) // в ТЗ сказанно что с помощью рекурсии нужно только вывести массив по этому создавал привычным способом
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;

}

void PrintArray(int[] array) // оставил для стравнения
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
    Console.ForegroundColor = ConsoleColor.White;
}

int[] ReverseArrray(int[]array) // не смог написать зеркальный в рекурсии, выбрал более легкий путь!
{
Array.Reverse(array);
return array;
}

void PrintArrayRecursion(int[] array, int current = 0) // РЕКУРСИЯ
        {
            
            if (current == array.Length) return;
            else
            {
                //Print(array, current);
                Console.Write(" " + array[current++]);
                PrintArrayRecursion(array, current);
            }
        }


System.Console.Write("Введи размер массива: ");
int sizeUser = Convert.ToInt32(Console.ReadLine());
int[] arrayUser = CreationArray(sizeUser);
PrintArray(arrayUser);
System.Console.WriteLine();
arrayUser = ReverseArrray(arrayUser);
PrintArrayRecursion(arrayUser);





