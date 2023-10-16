/*
28. Напишите программу, которая принимает на вход 
число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int Composition(int numb)
{
    int mult = 1;
    for (int i = 1; i <= numb; i++)
    {
        mult = mult * i;
    }
    return mult;
}



System.Console.WriteLine("Введи число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int resalt = Composition(namber);
System.Console.WriteLine($"произмедение чисел от 1 до {namber} = {resalt}");

