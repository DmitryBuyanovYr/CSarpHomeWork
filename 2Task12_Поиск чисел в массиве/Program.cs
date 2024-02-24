/*
Напишите программу которая ищет определенное число в массиве
*/

Console.Clear();
int[] array = new int[10];
System.Console.Write("Введи число: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
int exam = 0;
System.Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);
    System.Console.Write(array[i]);
    if (i< array.Length-1)
    {
        System.Console.Write("; ");
    }
    if (array[i] == numberUser)
    {
        exam ++;
    }
}
System.Console.Write("]");
System.Console.WriteLine();
if (exam > 0)
{
    System.Console.WriteLine($"Да");
}
else System.Console.WriteLine("нет");
