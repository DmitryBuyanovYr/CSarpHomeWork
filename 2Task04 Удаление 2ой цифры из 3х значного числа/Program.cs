/*
Напишите программу котора принимает 3х значное
число у уьирает 2 цифру этого числа
*/
Console.Clear();
System.Console.WriteLine("Введи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber > 100 || userNumber < 1000)
{
    int a = userNumber / 100;
    int b = userNumber % 10;
    System.Console.WriteLine(a*10 + b);
    //System.Console.WriteLine($"{a}{b}");
}
else System.Console.WriteLine("Ошибка");