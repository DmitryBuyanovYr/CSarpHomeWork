// напишите программу которая принимает число N 
// и выводит все целые числа от -N До N

Console.Clear();

System.Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = -number; i < number + 1; i++)
{
    System.Console.Write(i);
    if (i < number)
    {
        System.Console.Write(", ");
    }
}
