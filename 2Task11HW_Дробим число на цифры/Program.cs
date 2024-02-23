/*
Напишите программу, которая на вход принимает натуральное 
число N, а на выходе показывает его цифры через запятую.
5555-> 5.5.5.5
*/
int number = new Random().Next(0, 10000);
System.Console.WriteLine(number);
string resalt = number.ToString();
for (int i = 0; i < resalt.Length; i++)
{
    System.Console.Write(resalt[i]);
    if (i < resalt.Length - 1)
    {
        System.Console.Write("; ");
    }
}
