/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
System.Console.WriteLine("Введи число: ");
int nambr = Convert.ToInt32(Console.ReadLine());
int result = 0; 
for (int i = nambr; i >= 100; i = i / 10)
{
    result = i % 10;
}
if (nambr < 100)
{
    Console.WriteLine("3-его числа нет ");
}
else
{
    System.Console.WriteLine(result);
}