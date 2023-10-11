/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
//Console.Clear;
System.Console.WriteLine("Введите трехзначное число: ");
int nambr = Convert.ToInt32(Console.ReadLine());
if (nambr < 100 || nambr > 1000)
{
    Console.WriteLine("неверное число ");
}
else
{
    int result = nambr / 10 % 10;
System.Console.WriteLine(result);

}
