/*
Напишите программу, которая выводит третью слева цифру заданного 
числа или сообщает, что третьей цифры нет.
*/

int number = new Random().Next(10, 199);
System.Console.WriteLine(number);
string number2 = number.ToString();
if (number2.Length < 3)
{
    System.Console.WriteLine("Коротыш");
}
else
{
    System.Console.WriteLine(number2[2]);
}

/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
Console.WriteLine("Третьей цифры нет");
}
else
{
while (num > 999)
{
num /= 10; // num = num / 10
}
Console.WriteLine(num % 10);
}

string num_str = Convert.ToString(num);
if (num_str.Length < 3)
{
Console.WriteLine("Третьей цифры нет");
}
else Console.WriteLine(num_str[2]);
*/