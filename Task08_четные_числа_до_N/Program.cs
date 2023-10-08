/*
Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.
number = 5 -> 2    4
number = 8 -> 2    4    6    8
*/
System.Console.Write("Введи число: ");
int Nambr = Convert.ToInt32(Console.ReadLine());
int i;
if (Nambr < 0)
{
    Nambr = Nambr * -1;
}
for (i = 1; i < Nambr + 1; i++)
{
    if ((i % 2)==0)
    {
        Console.Write(i);
        if (i<Nambr)
        {
             Console.Write (", ");
        }
    }    
}