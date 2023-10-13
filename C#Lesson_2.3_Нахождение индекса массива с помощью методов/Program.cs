/*
Нахождение индекса массива с помощью методов
*/
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// создание рандомного массива

void PrintArray(int[] col)
{
    //int count = col.Length; лишняя строка
    int position = 0; // индекс массива
    while (position < col.Length/*count*/)
    {
        Console.Write(col[position]);
        position++;
    }

}

//вывод массива в терминал

int IndexOf(int[] collection, int find)
{
    //int count = collection.Length; лишняя строка
    int index = 0;
    int position = -1;

    while (index < collection.Length/*count*/)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// поиск индекса в массиве

int[] array = new int[10]; //new int[] (саздай новый массив с 10 элементами (поумолчанию все 0))

Console.Clear();
Console.Write("Введи число: ");
int userNambr = Convert.ToInt32(Console.ReadLine());

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, userNambr);
if (pos > -1)
{
    Console.WriteLine("Индекс числа " + pos);
}
if (pos == -1)
{
    Console.WriteLine("Такого числа в масиве нет!");
}