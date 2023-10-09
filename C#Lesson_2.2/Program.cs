int[] array = { 65, 11, 54, 64, 6, 51, 56, 4, 61, 44, 84, 89, 44, 51, 42, 1, };
int n = array.Length;
Console.WriteLine("введи число: ");
int userNambr = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index<n)
{
    if (array[index]==userNambr)
    {
        Console.WriteLine("индекс твоего числа: " + index);
        break;
    }

    index++;
}
