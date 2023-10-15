/*
Внутри класса Answer напишите метод ShowCube, который принимает 
на вход число (N) и выводит таблицу кубов чисел от 1 до N 
(включительно) каждое на новой строке.

N = 3---> 1:  8;  27;

N = 5---> 1: 8: 27: 64: 125
*/
Console.Clear();
System.Console.Write("Введи число: ");
int userNambr = Convert.ToInt32(Console.ReadLine());
if (userNambr < 0)
{
    userNambr = userNambr * -1;
}
for (int i = 1; i < userNambr + 1; i++)
{
    System.Console.Write(i * i * i);
    if (i < userNambr)
    {
        System.Console.Write(", ");
    }
}